using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Мікрософт.АспНетЯдро.Будівник;

var будівник = ВебАплікація.СтворитиБудівника(args);
будівник.Сервіси.ДодатиHttpПротоколювання(options => { });
будівник.Сервіси.ConfigureHttpJsonOptions(options =>
{
	options.SerializerOptions.TypeInfoResolverChain.Insert(0, СеріалізаційнийКонтекстJsonАпки.Default);
});

var апка = будівник.Побудувати();
var серверДії = "http://localhost:8080";
var код = "123";

апка.ВідобразитиGet("/v1/bank/oauth2/authorize", ([FromQuery(Name = "response_type")]string типЗапиту, [FromQuery(Name = "client_id")] string ідКлієнта, [FromQuery(Name = "state")] string стан, [FromQuery(Name = "bank_id")] string? ідБанка, [FromQuery(Name = "token")] string? token) =>
{
    if (token is null)
        return Results.Content("<h1>Привіт світ/h1>", "text/html");

	return Results.Content($"Redirecting to {серверДії}/api/v1/auth/bank-id/code/callback?code={код}.", statusCode: 302);
});

апка.ВідобразитиPost("/v1/bank/oauth2/token", ([FromForm(Name = "code")] string код, [FromForm(Name = "grant_type")] string типДозволу, [FromForm(Name = "client_id")] string ідКлієнта, [FromForm(Name = "client_secret")] string секретКлієнта) =>
{
	return Results.Content($$"""
{
 "token_type": "bearer",
 "access_token": "access_token",
 "expires_in": 180
}
""");
}).ВідключитиАнтіПідробку();

апка.ВідобразитиPost("/v1/bank/resource/client", () =>
{
	return Results.Json(new ІнформаціяКлієнта("state", "cert", "customerCrypto", "memberId"));
}).ВідключитиАнтіПідробку();

апка.ВикористовуватиПеренаправленняHttps();
апка.ВикористовуватиHttpПротоколювання();
апка.Запустити();

public record ІнформаціяКлієнта(string state, string cert, string customerCrypto, string memberId);

[JsonSerializable(typeof(ІнформаціяКлієнта))]
internal partial class СеріалізаційнийКонтекстJsonАпки : JsonSerializerContext
{

}

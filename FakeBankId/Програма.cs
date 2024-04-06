using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var будівник = ВебАплікація.СтворитиБудівника(args);
будівник.Сервіси.ДодатиHttpПротоколювання(options => { });
будівник.Сервіси.ConfigureHttpJsonOptions(options =>
{
	options.SerializerOptions.TypeInfoResolverChain.Insert(0, СеріалізаційнийКонтекстJsonАпки.Default);
});

var апка = будівник.Побудувати();
var серверДії = "http://localhost:8080";
var код = "123";

апка.MapGet("/api/banks", () =>
{
	return new[]
	{ 
		new ІнформаціяБанка("privatbank", "PrivatBank", true, "1436057001", "assets/images/banks/privatbank.png", "https://sandbox.binbu.privatbank.ua/BiNbu/oauth/authorize?response_type=code&client_id=478b231b-c93b-44b1-835e-7e288427ded6&state=", 5),
	};
});


апка.MapGet("/v1/bank/oauth2/authorize", ([FromQuery(Name = "response_type")] string типЗапиту, [FromQuery(Name = "client_id")] string ідКлієнта, [FromQuery(Name = "state")] string стан, [FromQuery(Name = "bank_id")] string? ідБанка, [FromQuery(Name = "token")] string? token) =>
{
    if (token is null)
        return Results.Content("<h1>Привіт світ/h1>", "text/html");

	return Results.Content($"Redirecting to {серверДії}/api/v1/auth/bank-id/code/callback?code={код}.", statusCode: 302);
});

апка.MapPost("/v1/bank/oauth2/token", ([FromForm(Name = "code")] string код, [FromForm(Name = "grant_type")] string типДозволу, [FromForm(Name = "client_id")] string ідКлієнта, [FromForm(Name = "client_secret")] string секретКлієнта) =>
{
	return new ІнформаціяЖетона("bearer", "access_token", 180);
}).ВідключитиАнтіПідробку();

апка.MapPost("/v1/bank/resource/client", () =>
{
	return new ІнформаціяКлієнта("state", "cert", "customerCrypto", "memberId");
}).ВідключитиАнтіПідробку();

апка.ВикористовуватиПеренаправленняHttps();
апка.ВикористовуватиHttpПротоколювання();
апка.Запустити();

public record ІнформаціяКлієнта(string state, string cert, string customerCrypto, string memberId);
public record ІнформаціяЖетона(string token_type, string access_token, int expires_in);
public record ІнформаціяБанка(string id, string name, bool workable, string memberId, string logoUrl, string loginUrl, int order);

[JsonSerializable(typeof(ІнформаціяКлієнта))]
[JsonSerializable(typeof(ІнформаціяЖетона))]
[JsonSerializable(typeof(ІнформаціяБанка[]))]
internal partial class СеріалізаційнийКонтекстJsonАпки : JsonSerializerContext
{

}

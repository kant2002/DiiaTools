using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var будівник = ВебАплікація.СтворитиБудівника(args);
будівник.Сервіси.ДодатиHttpПротоколювання(options => { });
//будівник.Сервіси.ConfigureHttpJsonOptions(options =>
//{
//    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
//});

var апка = будівник.Побудувати();
var серверДії = "http://localhost:8080";
var код = "123";

апка.ВідобразитиGet("/v1/bank/oauth2/authorize", ([FromQuery(Name = "response_type")]string response_type, [FromQuery(Name = "client_id")] string client_id, [FromQuery(Name = "state")] string state, [FromQuery(Name = "bank_id")] string? bank_id, [FromQuery(Name = "token")] string? token) =>
{
    if (token is null)
        return Results.Content("<h1>Привіт світ/h1>", "text/html");

	return Results.Content($"Redirecting to {серверДії}/api/v1/auth/bank-id/code/callback?code={код}.", statusCode: 302);
});

апка.ВикористовуватиПеренаправленняHttps();
апка.ВикористовуватиHttpПротоколювання();
апка.Запустити();

//public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

//[JsonSerializable(typeof(Todo[]))]
//internal partial class AppJsonSerializerContext : JsonSerializerContext
//{

//}

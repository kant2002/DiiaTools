using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(options => { });
//builder.Services.ConfigureHttpJsonOptions(options =>
//{
//    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
//});

var app = builder.Build();

app.MapGet("/v1/bank/oauth2/authorize", ([FromQuery(Name = "response_type")]string response_type, [FromQuery(Name = "client_id")] string client_id, [FromQuery(Name = "state")] string state, [FromQuery(Name = "bank_id")] string? bank_id, [FromQuery(Name = "token")] string? token) =>
{
    if (token is null)
        return Results.Content("<h1>Hello world</h1>", "text/html");
    var code = "123";

	return Results.Content($"Redirecting to http://localhost:8080/api/v1/auth/bank-id/code/callback?code={code}.", statusCode: 302);
});

app.UseHttpsRedirection();
app.UseHttpLogging();
app.Run();

//public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

//[JsonSerializable(typeof(Todo[]))]
//internal partial class AppJsonSerializerContext : JsonSerializerContext
//{

//}

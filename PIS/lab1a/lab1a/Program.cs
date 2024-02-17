var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/BKV",  (string ParmA, string ParmB) =>  $"GET-Http-BKV:ParmA = {ParmA},ParmB = {ParmB}");
app.MapPost("/BKV", (string ParmA, string ParmB) => $"POST-Http-BKV:ParmA = {ParmA},ParmB = {ParmB}");
app.MapPut("/BKV",  (string ParmA, string ParmB) =>  $"PUT-Http-BKV:ParmA = {ParmA},ParmB = {ParmB}");

app.MapPost("/4", async (context) =>
{
    var form = await context.Request.ReadFormAsync();

    int x = int.Parse(form["X"]);
    int y = int.Parse(form["Y"]);
    int sum = x + y;

    await context.Response.WriteAsync(sum.ToString());
});

app.Run();

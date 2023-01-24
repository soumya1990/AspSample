var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
var conn = configuration.GetValue<string>("ConnectionStrings");

Console.WriteLine("pwd:"+ conn);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


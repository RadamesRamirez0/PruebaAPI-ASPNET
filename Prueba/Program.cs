var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/net6", (string frase) => $".NET 6 es {frase}");
app.MapGet("sumar/{n1}/{n2}",
    (int n1, int n2) =>
    {
        return n1 + n2;
    });
app.MapGet("{n1}/mas/{n2}",
    (int n1, int n2) =>
    {
        return n1 + n2;
    });
app.MapGet("{n1}/menos/{n2}",
    (int n1, int n2) =>
    {
        return n1 - n2;
    });
app.MapGet("{n1}/entre/{n2}",
    (float n1, float n2) =>
    {
        return n1 / n2;
    });
app.MapGet("{n1}/por/{n2}",
    (int n1, int n2) =>
    {
        return n1 * n2;
    });
app.Run(); 


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddGraphQLServer();
app.MapGraphQL();

app.Run();

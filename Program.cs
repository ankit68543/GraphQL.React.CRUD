using GraphQL.React.CRUD.Contracts;
using GraphQL.React.CRUD.Mutation;
using GraphQL.React.CRUD.Query;
using GraphQL.React.CRUD.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddSingleton<IFoodService, FoodService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<FoodQuery>()
    .AddMutationType<FoodMutation>();

var app = builder.Build();

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.MapGraphQL();

app.Run();

using Amazon.Runtime.Internal;
using ClientService.API.Data;
using ClientService.API.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IContext, Context>();
builder.Services.AddScoped<IRepository, Repository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
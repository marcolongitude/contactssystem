using DomainServiceLayer.Services;
using DomainServiceLayer.Interfaces;
using InfrastructureLayer.Context;
using InfrastructureLayer.Repositories;
using InfrastructureLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["SqlConnection:SqlConnectionString"];

builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseMySql(
        connectionString,
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql")));
        
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<IContactsService, ContactsService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureContactsRoutes();

app.Run();
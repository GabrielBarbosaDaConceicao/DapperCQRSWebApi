using DapperWebApi.Context;
using DapperWebApi.CQRS.Commands;
using DapperWebApi.Interfaces;
using DapperWebApi.Repository;
using DapperWebApi.Services;
using DapperWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DapperDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

builder.Services.AddScoped<SqlConnectionRepository>();

builder.Services.AddMediatR(config =>
    config.RegisterServicesFromAssemblyContaining<CreateUserCommand>());

builder.Services.AddScoped<DapperWebApi.Interfaces.IUserRepository, UserRepository>();
builder.Services.AddScoped<DapperWebApi.Services.Interfaces.IUserService, UserService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

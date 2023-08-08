using ShopAPI.Application;

using ShopAPI.Infrastructure;
using ShopAPI.Infrastructure.Persistence;
using Serilog;

using Microsoft.OpenApi.Models;
using System.Text;
/*using Swashbuckle.AspNetCore.Filters;*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*builder.Host.UseSerilog((context, loggerConfig) => loggerConfig
    .WriteTo.Console()
    .ReadFrom.Configuration(context.Configuration));*/

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);


builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

builder.Services.AddHttpContextAccessor();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
        // Optionally, you can set a custom OAuth2 redirect URL for Swagger UI
        //c.OAuth2RedirectUrl("your-redirect-url");
    });
}


app.UseHttpsRedirection();

app.UseCors("all");


app.MapControllers();

app.Run();

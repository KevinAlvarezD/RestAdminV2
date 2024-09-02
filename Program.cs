using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

var builder = WebApplication.CreateBuilder(args);
Env.Load();
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbDatabaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var mySqlConnection = $"server={dbHost};port={dbPort};database={dbDatabaseName};uid={dbUser};password={dbPassword}";
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(mySqlConnection,ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
// app.UseWelcomePage();
app.UseAuthorization();
app.MapControllers();
app.Run();

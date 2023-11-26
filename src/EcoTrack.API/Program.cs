using EcoTrack.BL.Services.Users;
using EcoTrack.BL.Services.Users.Interfaces;
using EcoTrack.PL;
using EcoTrack.PL.Repositories.Users;
using EcoTrack.PL.Repositories.Users.Interface;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/ecotrack.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Add services to the container.
builder.Host.UseSerilog();
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
.AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EcoTrackDBContext>(options =>
{
    var mysqlConnection = builder.Configuration["ConnectionStrings:MySqlConnectionString"];
    options.UseMySql(mysqlConnection, ServerVersion.AutoDetect(mysqlConnection));
});
builder.Services.AddScoped<IUserRepository, SqlUserRepository>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<HashAlgorithm>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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

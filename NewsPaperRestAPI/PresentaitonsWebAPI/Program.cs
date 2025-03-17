using BusinessLayer.Extensions;
using FluentValidation;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Serilog loglama entegrasyonu
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddControllers();

// OpenAPI (Swagger) deste�i
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Agenda API", Version = "v1" });
});

// MemoryCache servisini ekleme (Caching i�in)
builder.Services.AddMemoryCache();

// FluentValidation servisini ekleme
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);


// AutoMapper ekleme
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// �� mant��� servislerini ekleme (Business katman� servisleri)
builder.Services.AddBusinessServices();

var app = builder.Build();
// Configure the HTTP request pipeline.


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Agenda API v1"));
}

// Hata y�netimi (Global Exception Handling)
app.UseExceptionHandler("/error");

// Loglama i�in Serilog middleware
app.UseSerilogRequestLogging();

app.UseAuthorization();
app.MapControllers();


app.Run();

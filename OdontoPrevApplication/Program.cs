using Microsoft.EntityFrameworkCore;
using OdontoPrevApplication.Application.Interfaces;
using OdontoPrevApplication.Application.Services;
using OdontoPrevApplication.Domain.Interfaces;
using OdontoPrevApplication.Infrastructure.Data.AppData;
using OdontoPrevApplication.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configure database connection

builder.Services.AddDbContext<ApplicationContext>(options => {
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

// Add repositories for DI
builder.Services.AddTransient<IBeneficiarioRepository, BeneficiarioRepository>();
builder.Services.AddTransient<IEnderecoRepository, EnderecoRepository>();

// Add services for DI
builder.Services.AddTransient<IBeneficiarioApplicationService, BeneficiarioApplicationService>();
builder.Services.AddTransient<IEnderecoApplicationService, EnderecoApplicationService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

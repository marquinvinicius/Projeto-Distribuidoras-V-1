using BackDistribuidora.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using Serilog.Extensions.Hosting;
using Serilog.Sinks.SystemConsole;
using Scalar.AspNetCore;
using System.Text.Json.Serialization;
using ApiDistribuidora.DTOs.Profiles;
using Microsoft.Extensions.DependencyInjection;
using ApiDistribuidora.Services.Interfaces;
using ApiDistribuidora.Services.Implementacoes;
using ApiDistribuidora.Repositories.Implementacoes;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Middleware;
using BackDistribuidora.Factory;
using AutoMapper;
using ApiDistribuidora.Estrategy.Interface;
using ApiDistribuidora.Estrategy.Implementacao;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

//Logs
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .Enrich.FromLogContext()
    .WriteTo.Console(
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}",
        restrictedToMinimumLevel: LogEventLevel.Information
    )
    .WriteTo.File(
        path: "logs/log-.txt",
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}",
        rollingInterval: RollingInterval.Day,
        restrictedToMinimumLevel: LogEventLevel.Information
    )
    .CreateLogger();

builder.Host.UseSerilog();

//Controllers e Json Options
builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
    );

//Banco de Dados
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"),
b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));


//Repositories
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IItemVendaRepository, ItemVendaRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IMarcaCategoriaRepository, MarcaCategoriaRepository>();
builder.Services.AddScoped<IMovimentacaoEstoqueRepository, MovimentacaoEstoqueRepository>();
builder.Services.AddScoped<IPrecoVendaRepository, PrecoVendaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IVendaRepository, VendaRepository>();

//Services
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IMarcaService, MarcaService>();  
builder.Services.AddScoped<IMarcaCategoriaService, MarcaCategoriaService>();
builder.Services.AddScoped<IMovimentacaoEstoqueService, MovimentacaoEstoqueService>();
builder.Services.AddScoped<IPrecoVendaService, PrecoVendaService>();
builder.Services.AddScoped<IVendaService, VendaService>();


//Factories
builder.Services.AddScoped<ProdutoFactory>();
builder.Services.AddScoped<IPrecoVendaFactory, PrecoVendaFactory>();

//Strategy
builder.Services.AddScoped<IMovimentacaoEstrategy, EntradaEstrategy>();
builder.Services.AddScoped<IMovimentacaoEstrategy, BonificacaoEstrategy>();
builder.Services.AddScoped<IMovimentacaoEstrategy, SaidaVendaEstrategy>();
builder.Services.AddScoped<IMovimentacaoEstrategy, SaidaPerdaTrocaEstrategy>();
builder.Services.AddScoped<IMovimentacaoEstrategy, AjusteEstoqueEstrategy>();

//Dto

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

//Scalar
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseErrorHandlingMiddleware();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
Log.CloseAndFlush();
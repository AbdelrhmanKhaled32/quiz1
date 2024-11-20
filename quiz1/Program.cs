using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Caegorierepo;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;
using WebApi_Abdelrhman_khaled_0522015_S4.Nationalityrepo;
using WebApi_Abdelrhman_khaled_0522015_S4.repodirectors;
using WebApi_Abdelrhman_khaled_0522015_S4.repomovie;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ctn")));
builder.Services.AddScoped<IMovie, Movierepo>();
builder.Services.AddScoped<Idirectors, Directorrepo>();
builder.Services.AddScoped<Icategories,Caegorierepo>();
builder.Services.AddScoped<INationality, Nationalityrepo>();
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

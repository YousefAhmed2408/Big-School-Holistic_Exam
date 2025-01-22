using Holistic_Exam.Data;
using Holistic_Exam.Models;
using Holistic_Exam.Reops.ClassRepo;
using Holistic_Exam.Reops.Teacher;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddConnections();
builder.Services.AddDbContext<AppdbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("pp")));
builder.Services.AddScoped<IClass, ClassRepo>();
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

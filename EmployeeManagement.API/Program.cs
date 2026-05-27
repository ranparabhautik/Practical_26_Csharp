using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Repository.Command;
using EmployeeManagement.DAL.Repository.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();


builder.Services.AddScoped<IEmployeeQueryRepository,EmployeeQueryRepository>();
builder.Services.AddScoped<IEmployeeCommandRepository,EmployeeCommandRepository>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using ChamCongNhanDienKhuonMat.DB;
using Microsoft.EntityFrameworkCore;
using NhanDienKhuonMat.Repository;
using NhanDienKhuonMat.Service;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//DB
builder.Services.AddDbContext<NhanDienDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NhanDienKhuonMat")));

//Time
//builder.Services.AddScoped<TimeRepositoty, TimeService>();
builder.Services.AddScoped<TimeService>();

///CORS
var CORS = "MyPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: CORS,
        builder =>
        {
            builder.WithOrigins("https://localhost:5173")
                   .AllowAnyHeader()
                   .WithMethods("GET", "POST", "PUT", "DELETE");
        });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

///CORS
app.UseCors();

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

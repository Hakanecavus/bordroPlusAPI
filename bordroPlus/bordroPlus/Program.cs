using bordroPlus;
using bP.Core;
using bP.Data;
using bP.Data.DBContext;
using bP.Engine.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "bordroPlusAPI", Version = "v1" });
    //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    //{
    //    Description = "JWT Authorization header using the Bearer scheme.",
    //    Name = "Authorization",
    //    In = ParameterLocation.Header,
    //    Scheme = "Bearer",
    //    Type = SecuritySchemeType.ApiKey,
    //    BearerFormat = "JWT"
    //});
    //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

builder.Services.DependecyInjectionCore();//TODO:Core Katmanýnýn injection iþlemlerini yapar
builder.Services.DependencyInjectionData();//TODO: Data Katmanýnýn injection iþlemini yapar
builder.Services.DependecyInjectionEngine();//TODO:Engine Katmanýnýn injection iþlemini yapar

builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

//builder.Services.AddDbContextPool<AppDBContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"), b => b.MigrationsAssembly("bordroPlus"));
//});



var serviceProvider = builder.Services.BuildServiceProvider(); //AppStart class ý program ilk çalýþtýðýnda default user ve role ekleyecek
AppStart.Initialize(serviceProvider);


var app = builder.Build();
IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;



app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "bordroPlus.Api v1"));

app.UseHttpsRedirection();
app.UseCors(x => x
      .AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader());
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
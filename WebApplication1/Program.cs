using AutoMapper;
using DemoWebApi.Common.Repositories;
using DemoWebApi.Common.Repositories.Base;
using DemoWebApiApps.Business.Services;
using DemoWebApiApps.Data.Data;
using DemoWebApiApps.Data.Repository.Base;
using DemoWebApiApps.Services;
using DemoWebApiApps.ViewModels;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.signIn.RequireConfirmedAccount=true).AddEnityFrameworkStores<ApplicationContext>();
//ConfigureDemoApiAppsServices(builder.Services);

builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserAPIService, UserAPIService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    Exception(app);
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void Exception(IApplicationBuilder app)
{
    app.UseExceptionHandler(
     builder =>
     {
         builder.Run(
         async context =>
         {
             context.Response.StatusCode =
          (int)HttpStatusCode.InternalServerError;
             context.Response.ContentType =
             "application/json";
             var exception =
             context.Features.Get
             <IExceptionHandlerFeature>();
             if (exception != null)
             {
                 var error = new ErrorMessageViewModel()
                 {
                     Stacktrace =
                     exception.Error.StackTrace,
                     Message = exception.Error.Message
                 };
                 var errObj =
                 JsonConvert.SerializeObject(error);
                 //await context.Response.WriteAsync
                 //(errObj).ConfigureAwait(false);

             }
         });
     }
);
}
void ConfigureDemoApiAppsServices(IServiceCollection service)
{
    service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    service.AddScoped<IUserRepository, UserRepository>();
    service.AddScoped<IUserService, UserService>();
    service.AddScoped<IUserAPIService, UserAPIService>();
    //service.AddAutoMapper()
}

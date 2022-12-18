using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Users.Contexts;
using Users.Repositories;
using Users.Repositories.Interfaces;
using Users.Services;
using Users.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();
builder.Services.AddDbContext<DefaultContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserDetailsRepository, UserDetailsRepository>();

builder.Services.AddScoped<IUserDetailsService, UserDetailsService>();

builder.Services.AddCors(o =>
{
    o.AddDefaultPolicy(
                  builder =>
                  {
                      builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .WithExposedHeaders("*");
                  });
});

var app = builder.Build();

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

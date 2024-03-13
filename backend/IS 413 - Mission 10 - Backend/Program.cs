using IS_413___Mission_10___Backend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddCors(); // Allows us to add permissions to certain origins

builder.Services.AddDbContext<BowlingLeagueContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlerConnection"])
);

builder.Services.AddScoped<IBowlingRepository, EFBowlingRepository>(); // Uses our repository for the project

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.WithOrigins("http://localhost:3000")); // Enables external users on local host 3000 to access the api

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

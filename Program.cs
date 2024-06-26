using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Context;

var builder = WebApplication.CreateBuilder(args);

const string allowDevelopmentCorsOriginsPolicy = "AllowDevelopmentSpecificOrigins";
const string localDevelopmentUrl = "http://localhost:4200";

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<NovelDbContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("DevelopmentDatabase")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowDevelopmentCorsOriginsPolicy,
        builder =>
        {
            builder.WithOrigins(localDevelopmentUrl)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    // Swashbuckle
    // app.UseSwagger();
    // app.UseSwaggerUI();

    // NSwag
    app.UseOpenApi();
    app.UseSwaggerUi();
} else {
    app.UseHsts();
}

app.UseHttpsRedirection();

// Not needed because we're not serving anything.
// app.UseDefaultFiles();
// app.UseStaticFiles();

app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseCors(allowDevelopmentCorsOriginsPolicy);
}

app.MapControllers();

app.Run();

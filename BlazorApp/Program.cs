using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorApp.Data;
using BlazorApp.Shared;
using System.Text.Json.Serialization;
using BlazorApp.DB_Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// [5] DEPENDANCY INJECTION BABY!!
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<FloorService>();
builder.Services.AddScoped<CounterState>();
builder.Services.AddDbContext<DbBensonbird25Context>(
    opt => opt.UseNpgsql(
        builder.Configuration.GetConnectionString("db_string")
        ));
builder.Services.AddRazorPages().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

//Not in production, just developement
//await EnsureDatabaseIsMigrated(app.Services);

async Task EnsureDatabaseIsMigrated(IServiceProvider s)
{
    using var scope = s.CreateScope();
    using var ctx=scope.ServiceProvider.GetService<DbBensonbird25Context>();
    if(ctx is not null)
        await ctx.Database.MigrateAsync();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

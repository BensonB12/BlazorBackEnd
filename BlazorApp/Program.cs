using BlazorApp.Data;
using BlazorApp.Shared;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Data.DbModel;


//public class Constants() { };



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<FloorService>();
builder.Services.AddScoped<CounterState>();
builder.Services.AddDbContextFactory<DbBensonbird25Context>(
    opt => opt.UseNpgsql(
        builder.Configuration.GetConnectionString("db_string")
        ));
//builder.Services.AddDbContext<ApplicationDbContext>(config => config.UseNpgsql());

/*builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.)
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFr*/
//builder.Services.AddHostedService<DefualtUserService>();
builder.Services.AddRazorPages().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

//Not in production, just developement
await EnsureDatabaseIsMigrated(app.Services);

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

app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

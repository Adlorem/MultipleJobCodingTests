using BIRBlazorTest.DBContext;
using BIRBlazorTest.Services;
using MFApiService.Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Daj klucz servisowy z ustawieñ
//var birKey = builder.Configuration.GetSection("BIRService").Value;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<RegonService>();
builder.Services.AddSingleton<IDefaultApi, DefaultApi>();

builder.Services.AddDbContext<CompanyDBContext>(options =>
{
    options.UseSqlite("Data Source = Company.db");
});

builder.Services.AddScoped<ICompanyServices, CompanyServices>();

var app = builder.Build();

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

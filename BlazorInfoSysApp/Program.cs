using Microsoft.EntityFrameworkCore;
using BlazorInfoSysApp.Models;
using MudBlazor.Services;
using BlazorInfoSysApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:InfoSysConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddHttpClient("PSGCApi", client => {
    client.BaseAddress = new Uri("https://psgc.cloud/api/");
});

builder.Services.AddScoped<ExportToExcelService>();

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();


var app = builder.Build();

if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/error");
}

app.UseStaticFiles();

app.MapControllers();
app.MapDefaultControllerRoute();
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();

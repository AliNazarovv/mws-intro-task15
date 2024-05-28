using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(cfg =>
{
    cfg.UseInMemoryDatabase("CountriesDb");
});

var app = builder.Build();




app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{controller=countries}/{action=index}/{id?}");


app.Seed();
app.Run();

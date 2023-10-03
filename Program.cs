/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}*/

//app.UseHttpsRedirection();

//app.UseRouting();

//app.UseAuthorization();

/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/

using Microsoft.EntityFrameworkCore;
using MyShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ItemDbContext>(options =>
{
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:ItemDbContextConnection"]);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
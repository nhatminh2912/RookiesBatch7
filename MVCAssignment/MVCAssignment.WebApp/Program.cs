

using MVCAssignment.WebApp.Areas.NashTech.Controllers;
using MVCAssignment.WebApp.Areas.NashTech.Models;

namespace MVCAssignment.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IPersonService, PersonService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapAreaControllerRoute(
                name: "MyAreaNashTech",
                areaName: "NashTech",
                pattern: "NashTech/{controller=Rookies}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "MyRouteNashTech",
                pattern: "{area:exists}/{controller=Rookies}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}

using E_Commerce.DataAccess.Data;
using E_Commerce.DataAccess.Repositries;
using E_Commerce.Entites.Intefaces;
using E_Commerce.Entites.Interfaces;
using E_Commerce.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            // Runtime compile    
            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            // Register DBContex
            builder.Services.AddDbContext<AppDBContext>(options => 
                             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConstr")));
            
            // Register UnitOfWork
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            
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

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            
            
            app.Run();
        }
    }
}

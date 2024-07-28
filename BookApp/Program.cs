using BookApp.ViewModel;
using Data.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("Connection");
			// Add services to the container.
			builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BookDbContext>(options=>
            options.UseSqlServer(connectionString));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<BookDbContext>();

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
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=accounts}/{action=Login}/{id?}");

                app.Run();
        }
    }
}

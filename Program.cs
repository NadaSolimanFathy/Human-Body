using Human_Body.Context;
using Human_Body.Interfaces;
using Human_Body.Repository;
using Human_Body.SeedData;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Human_Body
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<HumanBodyDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IHumanBodyRepository, HumanBodyRepository>();

            var app = builder.Build();
            ApplySeeding.ApplySeedingAsync(app);



            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Human}/{action=Index}");

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
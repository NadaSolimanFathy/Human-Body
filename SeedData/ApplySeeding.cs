using Human_Body.Context;
using Microsoft.EntityFrameworkCore;

namespace Human_Body.SeedData
{
    public class ApplySeeding
    {



        public static async Task ApplySeedingAsync(WebApplication app)
        {



            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<HumanBodyDbContext>();
                    await context.Database.MigrateAsync();
                    await ContextSeed.SeedAsync(context, loggerFactory);
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<HumanBodyDbContext>();
                    logger.LogError(ex.Message);
                }

            }
        }
    }
}

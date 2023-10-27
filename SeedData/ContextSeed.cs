using Human_Body.Context;
using Human_Body.Model;
using System.Text.Json;

namespace Human_Body.SeedData
{
    public class ContextSeed
    {

            public static async Task SeedAsync(HumanBodyDbContext context, ILoggerFactory loggerFactory)


            {
                try
                {
                    if (context.humanBodyOrgans != null && !context.humanBodyOrgans.Any())
                    {
                        var OrgansData = File.ReadAllText("SeedData/HumanOrgans.json");
                        //                                       retuen                 source   
                        var organs = JsonSerializer.Deserialize< List<HumanBody>>(OrgansData);

                        if (organs != null)
                        {
                            foreach (var organ in organs)
                            {
                                await context.humanBodyOrgans.AddAsync(organ);
                            }
                            await context.SaveChangesAsync();
                        }

                    }

                   
                   

                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<HumanBodyDbContext>();
                    logger.LogError(ex.Message);
                }

            }
        }
    
}

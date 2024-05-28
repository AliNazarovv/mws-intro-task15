using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Contexts
{
    public static class DataSeed
    {

        internal static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DataContext>();
                var list = new[] {
               new Country { Id = 1, Name = "Azerbaijan", Code = "+994"},
                new Country { Id = 2, Name = "Turkey", Code = "+90" },
                new Country { Id = 3, Name = "United State", Code = "+1" },
                new Country { Id = 4, Name = "Germany", Code = "+49" },
                new Country { Id = 5, Name = "Greece", Code = "+30" }


            };

                db.Countries.AddRange(list);
                db.SaveChanges();
            }
            return app;
        }
    }
}

using MenuProject.Models;

namespace MenuProject.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using( var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            var currentTime = DateTime.Now; //WIP for DateTime instead of Timestamp under Model
            if (!context.Menus.Any())
            {
                Console.WriteLine("Seeding Data...");

                context.Menus.AddRange(
                    new Menu() { Name = "Coca-cola", Size = "0,5L", Price = "28,00 DKK" },
                    new Menu() { Name = "Pepsi Max", Size = "1,5L", Price = "39,00 DKK" },
                    new Menu() { Name = "Vesuvio", Size = "Alm", Price = "79,00 DKK" },
                    new Menu() { Name = "Pepperoni", Size = "Fam", Price = "158,00 DKK" },
                    new Menu() { Name = "Italiano", Size = "Alm", Price = "85,00 DKK" },
                    new Menu() { Name = "Hawaii", Size = "Alm", Price = "86,00 DKK" },
                    new Menu() { Name = "Omelet", Size = "Alm", Price = "87,00 DKK" },
                    new Menu() { Name = "Polermo", Size = "Alm", Price = "88,00 DKK" },
                    new Menu() { Name = "Beckham", Size = "Alm", Price = "89,00 DKK" },
                    new Menu() { Name = "Simon", Size = "Alm", Price = "88,00 DKK" },
                    new Menu() { Name = "Egedal", Size = "Alm", Price = "93,00 DKK" },
                    new Menu() { Name = "Torino", Size = "Alm", Price = "89,00 DKK" },
                    new Menu() { Name = "Juventus", Size = "Alm", Price = "87,00 DKK" },
                    new Menu() { Name = "Natali", Size = "Alm", Price = "89,00 DKK" },
                    new Menu() { Name = "Centrum", Size = "Alm", Price = "93,00 DKK" },
                    new Menu() { Name = "Gorgonzola", Size = "Alm", Price = "85,00 DKK" },
                    new Menu() { Name = "Parma", Size = "Alm", Price = "94,00 DKK"  },
                    new Menu() { Name = "Pommes Fritter", Size = "Mellem", Price = "42,00 DKK"});
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We Already have data");
            }
        }
    }
}

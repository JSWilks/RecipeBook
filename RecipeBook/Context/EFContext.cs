using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System;
using static Azure.Core.HttpHeader;
using Humanizer;
using Microsoft.CodeAnalysis.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;

namespace RecipeBook.Context
{
    public class EFContext : DbContext
    {
        private readonly IConfiguration configuration;

        public EFContext(IConfiguration configuration)
        {
            this.configuration = configuration ?? throw new ArgumentNullException(paramName: nameof(configuration), message: "IConfiguration is not defined");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            if (connectionString == null)
            {
                throw new InvalidOperationException("Can Not find ConnectionString DefaultConnection");
            }
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Recipe> Recipes { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Recipe>().HasData(

                new Recipe()
                {
                    Id = 1,
                    Name = "Sweet potato soup",
                    Ingredients = 
                    {
                        "1 white onion (halved and sliced)",
                        "3 garlic cloves (diced)",
                        "4 golden sweet potatoes (halved and sliced)",
                        "2 large carrots (sliced into rounds)",
                        "1 jalapeno (diced)",
                        "1 tomato (diced)",
                        "1-2 TBS butter or coconut oil",
                        "Apple cider vinegar",
                        "1 TBS horseradish powder",
                        "1 TBS Better than bouillon adobo",
                        "1 tsp dried basil",
                        "~ 3qts of water",
                        "1 can coconut milk",
                        "Salt and pepper"
                    },
                    Steps = 
                    {
                        "In a 6 qt stock pot (with lid), use butter or coconut oil to saute onion and garlic cloves for about 5 minutes.",
                        "Add horseradish powder and stir until",
                        "It has absorbed the oil.",
                        "Deglaze using a splash of apple cider vinegar.",
                        "Add water.",
                        "Add sweet potatoes, carrots, jalapenos, tomato, and basil.",
                        "Stir in bouillon and coconut milk.",
                        "Bring to a simmer and cover for about 45 minutes, stirring occasionally.",
                        "Should be good once you can smash a potato pretty easy with your spoon.",
                        "Salt and pepper to taste!"
                    },
                    Notes = 
                    {
                        "If you want a more savory soup- \r\nUse regular potatoes \r\nAdd 1/4 tsp ground fennel seed \r\nAdd sliced celery\r\nLeave out the coconut milk.\r\nAfter the soup is done cooking, remove from heat and immediately stir in 1 cup of heavy cream."
                    }
                }

                );

            //    modelBuilder.Entity<Recipe>().HasData(

            //        new Recipe() { 
            //        {
            //            Name = "Recipe1",
            //            Ingredients = ingredients,
            //            Steps = steps,
            //            Notes = notes
            //        },

            //new WeatherForecast()
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index++)),
            //    TemperatureC = Random.Shared.Next(-20, 55)
            //}
            //);
        }
    }
}

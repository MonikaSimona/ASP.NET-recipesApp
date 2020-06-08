using HealthyRecipes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyRecipes.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new HealthyRecipesContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<HealthyRecipesContext>>());
            if (context.Recipe.Any() || context.Ingredient.Any() || context.Chef.Any())
            {
                return;
            }
            context.Chef.AddRange(
                new Chef { FirstName = "Gordon", LastName = "Ramsey" },
                new Chef { FirstName = "Jamie", LastName = "Oliver" },
                new Chef { FirstName = "Martha", LastName = "Stewart" },
                new Chef { FirstName = "Monika", LastName = "Geller" }

                );
            context.SaveChanges();

            context.Ingredient.AddRange(
               new Ingredient { Name = "Banana", ImageUrl = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2013/04/22/18/24-Banana.jpg", CaloriesPerItem = 89, ProteinsPerItem = 1.1, SugarPerItem = 12.2, IngredientFact = "Bananas are a healthy source of fiber, potassium, vitamin B6, vitamin C, and various antioxidants and phytonutrients.Many types and sizes exist.Their color usually ranges from green to yellow,but some varieties are red." },
               new Ingredient { Name = "Egg", ImageUrl = "https://assets.teenvogue.com/photos/5c58898b360bd63de9436118/16:9/w_1280%2Cc_limit/GettyImages-914246230.jpg", CaloriesPerItem = 75, ProteinsPerItem = 6, SugarPerItem = 0.5, IngredientFact = "An egg’s shell color doesn’t indicate the quality or nutritional value of an egg, but rather the breed of the hen that laid it. Hens with white feathers tend to lay white eggs and hens with red feathers tend to lay brown eggs." },
               new Ingredient { Name = "Coco", ImageUrl = "http://www.tradelinkinternational.com/sa/wp-content/uploads/2018/08/iStock-462209375.jpg", CaloriesPerItem = 400, ProteinsPerItem = 19.6, SugarPerItem = 1.8, IngredientFact = "Cocoa powder is one of the world’s oldest foods, and it is also one of the healthiest.Interestingly,cocoa powder has been enjoyed for more than 4000 years now." },
               new Ingredient { Name = "Apple", ImageUrl = "http://dreamicus.com/data/apple/apple-05.jpg", CaloriesPerItem = 52, ProteinsPerItem = 0.3, SugarPerItem = 10.4, IngredientFact = "Apple trees take four to five years to produce their first fruit.Apples contain no fat, sodium or cholesterol and are a good source of fiber." }

                );
            context.SaveChanges();

            context.Recipe.AddRange(
                new Recipe { Title = "3 Ingredients Microwave Mug Cake", ImageUrl = "https://cf-images.us-east-1.prod.boltdns.net/v1/static/1033249144001/abd9e8fd-dc3b-4b17-9d94-9f856212a1b1/d4b5c8a8-5b91-4a92-b90a-fe6c225f3f2f/1280x720/match/image.jpg", Description = "Put all of the ingredients in the mug. Mix it well and put the mug in the microwave for 2 minutes. Enjoy!", PrepareTime = new TimeSpan(0, 2, 0), Type = "sweet", ChefId = context.Chef.Single(c => c.FirstName == "Gordon" && c.LastName == "Ramsey").Id }
                );
            context.SaveChanges();

            context.RecipeIngredient.AddRange(
                new RecipeIngredient { RecipeId = 1, IngredientId = 1 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 2 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 3 }

                );
            context.SaveChanges();
        }

    }
}

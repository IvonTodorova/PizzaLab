using PizzaLab.Data.PizzaLab.Data.Models;
using PizzaLab.Data.PizzaLab.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLab.Data.EntityData
{
   public class ProductsData
    {
        private static readonly Random Rng = new Random();

        public static ICollection<Product> GetPizzas()
        {

            var products = new List<Product>()
            {
                new Product
                {
                    Name = "Basic Cheese",
                    Description = "Cheesus, that's a lot of cheese.",
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "bg_1",
                            MediaType = "jpg",
                            Path = "~/images",

                        },
                        new MediaItem()
                        {

                            Name = "bg_2",
                            MediaType = "png",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            IngridientId = 1,
                            ProductId = 1,
                            DischargedUnits = 3,
                            IsOptionalForAddingAProduct=true,
                        },
                        new ProductsIngridients()
                        {
                            IngridientId = 2,
                            ProductId = 1,
                            DischargedUnits = 2,
                            IsOptionalForAddingAProduct = true,

                        },
                        new ProductsIngridients()
                        {
                            IngridientId = 3,
                            ProductId = 1,
                            DischargedUnits = 1,
                            IsOptionalForAddingAProduct=true,

                        },
                     },

                    Price = Rng.Next(5, 10),
                },
                new Product
                {
                    Name = "Italian Pizza",
                    Description = "A classic!",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "image_3",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "image_6",
                            MediaType = "png",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 2,
                            IngridientId = 2,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,

                        },
                     },
                },
                new Product
                {
                    Name = "American Pizza",
                    Description = "Vegetables and ham, what more could you want?",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "pizza-1",
                            MediaType = "png",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "pizza-2",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 3,
                            IngridientId = 3,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Pure Peperoni",
                    Description = "The timeless classic.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "pizza-3",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "pizza-4",
                            MediaType = "png",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 4,
                            IngridientId = 4,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Margherita",
                    Description = "No animals were harmed in the making of this pizza.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "pizza-5",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "pizza-6",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 5,
                            IngridientId = 5,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Bacon Pizza",
                    Description = "Shred and tear.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "pizza-7",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "pizza-8",
                            MediaType = "png",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 6,
                            IngridientId = 6,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Ham & Pineapple",
                    Description = "Contains a lot of orange, except oranges.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images1",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images2",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 7,
                            IngridientId = 7,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Venus",
                    Description = "All kinds of cheese.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images3",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images4",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 8,
                            IngridientId = 1,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "The Rock",
                    Description = "It looks like a rock.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images5",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images6",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 9,
                            IngridientId = 2,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Exotica",
                    Description = "Pineapple pizza for the more extravagant.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images7",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images8",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 10,
                            IngridientId = 3,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Kelvin",
                    Description = "Very hot.",
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images9",
                            MediaType = "png",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images10",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 11,
                            IngridientId = 5,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Modern Italian",
                    Description = "Just like the italians but bigger and denser.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images10",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images10",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 12,
                            IngridientId = 6,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Yellowstone",
                    Description = "It's very yellow.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images11",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images12",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 13,
                            IngridientId = 7,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Big Boss",
                    Description = "This one has everything.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images13",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images14",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 14,
                            IngridientId = 1,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Forest",
                    Description = "The green stuff is probably healthy.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images15",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images16",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 15,
                            IngridientId = 2,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Tomato Hell",
                    Description = "Mama Mia, that's a lot of tomatoes.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images17",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images18",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 16,
                            IngridientId = 3,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Tomato Vegan",
                    Description = "More tomatoes, less meat.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images19",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images20",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 17,
                            IngridientId = 5,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Meatmania",
                    Description = "Lots of animal protein..",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images21",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images22",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 18,
                            IngridientId = 7,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Burger Pizza",
                    Description = "It's a burger but turned into a pizza.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images23",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images24",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 19,
                            IngridientId = 1,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Sauce please",
                    Description = "Bring on the sauce!",
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images25",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images26",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 20,
                            IngridientId = 2,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Star",
                    Description = "Peperoni in the shape of a star. Who even makes these things?",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images27",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images28",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 21,
                            IngridientId = 4,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Random",
                    Description = "We'll just throw whatever's left",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images29",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images28",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 22,
                            IngridientId = 5,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=true,
                        },
                     },
                },
                new Product
                {
                    Name = "Devil",
                    Description = "Red and spicy",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images30",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images31",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 23,
                            IngridientId = 4,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },
                },
                new Product
                {
                    Name = "Creamy",
                    Description = "Cream cheese for all.",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images32",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images33",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 24,
                            IngridientId = 1,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },

                },
                new Product
                {
                    Name = "Striped",
                    Description = "The white stuff is just ranch sauce, we swear!",
                    Price = Rng.Next(5, 10),
                    MediaItems = new List<MediaItem>()
                    {
                        new MediaItem()
                        {
                            Name = "images34",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                        new MediaItem()
                        {

                            Name = "images35",
                            MediaType = "jpg",
                            Path = "~/images",
                        },
                    },
                    ProductsIngridients = new List<ProductsIngridients>()
                     {
                        new ProductsIngridients()
                        {
                            ProductId = 25,
                            IngridientId = 2,
                            DischargedUnits=10,
                            IsOptionalForAddingAProduct=false,
                        },
                     },

                },
            };
            return products;
        }
    }
}

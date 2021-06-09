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
                            MediaType = "png",
                            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                        },
                        new MediaItem()
                        {

                            Name = "bg_2",
                            MediaType = "png",
                            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
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
                            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                        },
                        new MediaItem()
                        {

                            Name = "image_6",
                            MediaType = "png",
                            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                        },
                    },
                },
                //new Product
                //{
                //    Name = "Greek Pizza",
                //    Description = "Classic peperoni but with vegetables.",
                //    Price = Rng.Next(5, 10),
                //},
                //new Product
                //{
                //    Name = "American Pizza",
                //    Description = "Vegetables and ham, what more could you want?",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "pizza-1",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "pizza-2",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Pure Peperoni",
                //    Description = "The timeless classic.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "pizza-3",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "pizza-4",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Margherita",
                //    Description = "No animals were harmed in the making of this pizza.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "pizza-5",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "pizza-6",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Bacon Pizza",
                //    Description = "Shred and tear.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "pizza-7",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "pizza-8",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Ham & Pineapple",
                //    Description = "Contains a lot of orange, except oranges.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (1)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (2)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Venus",
                //    Description = "All kinds of cheese.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (3)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (4)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "The Rock",
                //    Description = "It looks like a rock.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (5)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (6)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Exotica",
                //    Description = "Pineapple pizza for the more extravagant.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (7)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (8)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Kelvin",
                //    Description = "Very hot.",
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (9)",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (10)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Modern Italian",
                //    Description = "Just like the italians but bigger and denser.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (10)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (10)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Yellowstone",
                //    Description = "It's very yellow.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (11)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (12)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Big Boss",
                //    Description = "This one has everything.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (13)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (14)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Forest",
                //    Description = "The green stuff is probably healthy.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (15)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (16)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Tomato Hell",
                //    Description = "Mama Mia, that's a lot of tomatoes.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (17)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (18)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Tomato Vegan",
                //    Description = "More tomatoes, less meat.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (19)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (20)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Meatmania",
                //    Description = "Lots of animal protein..",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (21)",
                //            MediaType = "png",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (22)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Burger Pizza",
                //    Description = "It's a burger but turned into a pizza.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (23)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (24)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Sauce please",
                //    Description = "Bring on the sauce!",
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (25)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (26)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Star",
                //    Description = "Peperoni in the shape of a star. Who even makes these things?",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (27)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (28)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Random",
                //    Description = "We'll just throw whatever's left",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (29)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (28)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },
                //},
                //new Product
                //{
                //    Name = "Devil",
                //    Description = "Red and spicy",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (30)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (31)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },

                //},
                //new Product
                //{
                //    Name = "Creamy",
                //    Description = "Cream cheese for all.",
                //    Price = Rng.Next(5, 10),
                //    MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (32)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (33)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },

                //},
                //new Product
                //{
                //    Name = "Striped",
                //    Description = "The white stuff is just ranch sauce, we swear!",
                //     Price = Rng.Next(5, 10),
                //     MediaItems = new List<MediaItem>()
                //    {
                //        new MediaItem()
                //        {
                //            Name = "images (34)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //        new MediaItem()
                //        {

                //            Name = "images (35)",
                //            MediaType = "jpg",
                //            Path = "C:/Users/IVON/Downloads/pizza-pages/images",
                //        },
                //    },

                //},
            };
            return products;
        }
    
    }
}

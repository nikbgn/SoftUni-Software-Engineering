namespace ProductShop
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using ProductShop.Data;
    using ProductShop.Models;


    using Newtonsoft.Json;
    using ProductShop.DTOs.User;
    using AutoMapper;
    using ProductShop.DTOs.Product;
    using ProductShop.DTOs.Category;
    using ProductShop.DTOs.CategoryProduct;
    using AutoMapper.QueryableExtensions;
    using Newtonsoft.Json.Serialization;

    public class StartUp
    {
        private static string filePath;
        public static void Main(string[] args)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(typeof(ProductShopProfile));
            });
            ProductShopContext dbContext = new ProductShopContext();
            InitializeOutputFilepath("users-and-products.json");

            /*
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            Console.WriteLine("Created!");
            */


            string json = GetUsersWithProducts(dbContext);
            File.WriteAllText(filePath, json);


        }

        //T01
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var userDtos = JsonConvert.DeserializeObject<ImportUserDto[]>(inputJson);
            ICollection<User> users = new List<User>();
            foreach (ImportUserDto userDto in userDtos)
            {
                User user = Mapper.Map<User>(userDto);
                users.Add(user);
            }

            context.Users.AddRange(users);
            context.SaveChanges();
            return $"Successfully imported {users.Count}";
        }
        //T02
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var productDtos = JsonConvert.DeserializeObject<ImportProductDto[]>(inputJson);
            ICollection<Product> products = new List<Product>();
            foreach (ImportProductDto productDTO in productDtos)
            {
                Product product = Mapper.Map<Product>(productDTO);
                products.Add(product);
            }
            context.Products.AddRange(products);
            context.SaveChanges();
            return $"Successfully imported {products.Count}";
        }
        //T03
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categoryDtos = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);
            ICollection<Category> categories = new List<Category>();
            foreach (ImportCategoryDto categoryDto in categoryDtos)
            {
                Category category = Mapper.Map<Category>(categoryDto);
                if (category.Name != null) categories.Add(category);
                continue;
            }
            context.Categories.AddRange(categories);
            context.SaveChanges();
            return $"Successfully imported {categories.Count}";
        }
        //T04
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryProductDtos =
                JsonConvert.DeserializeObject<ImportCategoryProductDto[]>(inputJson);
            ICollection<CategoryProduct> caregoryProducts = new List<CategoryProduct>();
            foreach (ImportCategoryProductDto categoryProductDto in categoryProductDtos)
            {
                var categoryProduct = Mapper.Map<CategoryProduct>(categoryProductDto);
                caregoryProducts.Add(categoryProduct);
            }
            context.CategoryProducts.AddRange(caregoryProducts);
            context.SaveChanges();
            return $"Successfully imported {caregoryProducts.Count}";
        }
        //T05
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products =
                context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .ProjectTo<ExportProductsInRangeDto>()
                .ToArray();

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            return json;
        }
        //T06
        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersWithSoldProducts =
                context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                    .Where(ps => ps.Buyer != null)
                    .Select(sp => new
                    {
                        name = sp.Name,
                        price = sp.Price,
                        buyerFirstName = sp.Buyer.FirstName,
                        buyerLastName = sp.Buyer.LastName
                    })
                })
                .OrderBy(u => u.lastName)
                .ThenBy(u => u.firstName)
                .ToArray();

            var json = JsonConvert.SerializeObject(usersWithSoldProducts, Formatting.Indented);
            return json;
        }
        //T07
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    category = c.Name,
                    productsCount = c.CategoryProducts.Count,
                    averagePrice = $"{c.CategoryProducts.Average(p => p.Product.Price):F2}",
                    totalRevenue = $"{c.CategoryProducts.Sum(p => p.Product.Price):F2}"
                })
                .OrderByDescending(p => p.productsCount)
                .ToArray();

            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            return json;
        }
        //T08
        public static string GetUsersWithProducts(ProductShopContext context)
        {

            var users = context
                .Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderByDescending(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Count,
                        products = u.ProductsSold
                        .Where(p => p.Buyer != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                    }

                })
                .ToList();

            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var result = new
            {
                usersCount = users.Count,
                users = users
            };
            
            var json = JsonConvert.SerializeObject(result, Formatting.Indented,settings);

            return json;
        }
            private static void InitializeOutputFilepath(string fileName)
        {
            filePath =
                Path.Combine(Directory.GetCurrentDirectory(), "../../../Results/", fileName);
        }
    }
}
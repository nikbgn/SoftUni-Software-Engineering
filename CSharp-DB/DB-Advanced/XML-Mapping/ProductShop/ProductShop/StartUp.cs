namespace ProductShop
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using ProductShop.Data;
    using ProductShop.Dtos.Export;
    using ProductShop.Dtos.Import;
    using ProductShop.Models;

    public class StartUp
    {
        private static string filePath;
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            OutputXMLToFile("users-and-products");
            File.WriteAllText(filePath, GetUsersWithProducts(context));

            /*
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Created");
            */
        }

        //T01
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(ImportUserModel[]),
                new XmlRootAttribute("Users"));

            var reader = new StringReader(inputXml);

            var userDtos = serializer.Deserialize(reader) as ImportUserModel[];

            var users = userDtos
                .Select(u => new User
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age
                })
                .ToList();
            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }
        //T02
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportProductModel[]),
                new XmlRootAttribute("Products"));

            var reader = new StringReader(inputXml);

            var productDtos = serializer.Deserialize(reader) as ImportProductModel[];

            var products =
                productDtos
                .Select(p => new Product
                {
                    Name = p.Name,
                    Price = p.Price,
                    SellerId = p.SellerId,
                    BuyerId = p.BuyerId
                })
                .ToList();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";

        }
        //T03
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(ImportCategoryModel[]),
                new XmlRootAttribute("Categories"));

            var reader = new StringReader(inputXml);

            var categoryDtos = serializer.Deserialize(reader) as ImportCategoryModel[];

            var categories =
                categoryDtos
                .Where(c => string.IsNullOrEmpty(c.Name) == false)
                .Select(c => new Category
                {
                    Name = c.Name
                })
                .ToList();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }
        //T04
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportCategoryProductModel[]),
                new XmlRootAttribute("CategoryProducts"));

            var reader = new StringReader(inputXml);

            var categoryProductDtos =
                serializer.Deserialize(reader) as ImportCategoryProductModel[];

            var categoryproduct =
                categoryProductDtos
                .Select(cp => new CategoryProduct
                {
                    CategoryId = cp.CategoryId,
                    ProductId = cp.ProductId
                })
                .ToList();

            context.CategoryProducts.AddRange(categoryproduct);
            context.SaveChanges();


            return $"Successfully imported {categoryproduct.Count}";
        }
        //T05
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ProductInRangeModel
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .Take(10)
                .ToArray();

            XmlSerializer serializer =
                new XmlSerializer(typeof(ProductInRangeModel[]),
                new XmlRootAttribute("Products"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, products, ns);

            var result = writer.ToString();

            return result;
        }
        //T06
        public static string GetSoldProducts(ProductShopContext context)
        {
            var soldProducts = context.Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new UserSoldProductsModel
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts =
                        u.ProductsSold
                            .Where(ps => ps.Buyer != null)
                            .Select(ps => new ProductNamePriceModel
                            {
                                Name = ps.Name,
                                Price = ps.Price
                            }).ToArray()
                })
                .Take(5)
                .ToArray();


            XmlSerializer serializer =
                new XmlSerializer(typeof(UserSoldProductsModel[]),
                new XmlRootAttribute("Users"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, soldProducts, ns);

            var result = writer.ToString();


            return result;

        }
        //T07
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new CategoryByProductModel
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(p => p.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(p => p.Product.Price)
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();


            XmlSerializer serializer =
                new XmlSerializer(typeof(CategoryByProductModel[]),
                new XmlRootAttribute("Categories"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, categories, ns);

            var result = writer.ToString();


            return result;
        }
        //T08
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(u => u.ProductsSold.Count())
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductModel
                    {
                        Count = u.ProductsSold.Count(),
                        Products = u.ProductsSold
                        .Select(ps => new ProductNamePriceModel
                        {
                            Name = ps.Name,
                            Price = ps.Price
                        })
                        .OrderByDescending(ps => ps.Price)
                        .ToArray()
                    }

                })
                .Take(10)
                .ToArray();

            var returnData = new BigUserProductModel
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = users
            };

            XmlSerializer serializer =
                new XmlSerializer(typeof(BigUserProductModel),
                new XmlRootAttribute("Users"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, returnData, ns);

            var result = writer.ToString();


            return result;

        }
        public static void ReadXMLFromFile(string fileName)
            => filePath = $"../../../Datasets/{fileName}.xml";

        public static void OutputXMLToFile(string fileName)
            => filePath = $"../../../Results/{fileName}.xml";

    }
}
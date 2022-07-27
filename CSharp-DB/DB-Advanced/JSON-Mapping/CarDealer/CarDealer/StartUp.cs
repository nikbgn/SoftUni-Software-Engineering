using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO.Car;
using CarDealer.DTO.Customer;
using CarDealer.DTO.Part;
using CarDealer.DTO.Sale;
using CarDealer.DTO.Supplier;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        private static string filePath;
        public static void Main(string[] args)
        {

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(typeof(CarDealerProfile));
            });

            CarDealerContext context = new CarDealerContext();

            SetExportFilePath("sales-discounts");



            File.WriteAllText(filePath, GetSalesWithAppliedDiscount(context));

            /*
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Created!");
            */
        }

        //T01
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<ImportSuppliersDto[]>(inputJson);
            ICollection<Supplier> suppliersCollection = new List<Supplier>();
            foreach (ImportSuppliersDto suppliersDto in suppliers)
            {
                Supplier supplier = Mapper.Map<Supplier>(suppliersDto);
                suppliersCollection.Add(supplier);
            }
            context.Suppliers.AddRange(suppliersCollection);
            context.SaveChanges();
            return $"Successfully imported {suppliersCollection.Count}.";
        }
        //T02
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var parts = JsonConvert.DeserializeObject<Part[]>(inputJson)
                        .Where(p => context.Suppliers.Any(s => s.Id == p.SupplierId))
                        .ToArray();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Length}.";
        }
        //T03
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsDto = JsonConvert.DeserializeObject<IEnumerable<ImportCarDto>>(inputJson);

            var listOfCars = new List<Car>();

            foreach (var car in carsDto)
            {
                var currentCar = new Car
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TravelledDistance
                };
                foreach (var partId in car?.PartsId.Distinct())
                {
                    currentCar.PartCars.Add(new PartCar
                    {
                        PartId = partId
                    });
                }
                listOfCars.Add(currentCar);
            }
            context.Cars.AddRange(listOfCars);
            context.SaveChanges();

            return $"Successfully imported {listOfCars.Count}.";
        }
        //T04
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {

            var customerDtos = JsonConvert
                .DeserializeObject<IEnumerable<ImportCustomerDto>>(inputJson);

            var Customers = new List<Customer>();

            foreach (var customerDto in customerDtos)
            {
                Customer currCustomer = new Customer()
                {
                    Name = customerDto.Name,
                    BirthDate = customerDto.BirthDate,
                    IsYoungDriver = customerDto.IsYoungDriver
                };

                Customers.Add(currCustomer);

            }

            context.Customers.AddRange(Customers);
            context.SaveChanges();

            return $"Successfully imported {Customers.Count}.";
        }
        //T05
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var salesDtos = JsonConvert
                .DeserializeObject<IEnumerable<ImportSaleDto>>(inputJson);

            var sales = new List<Sale>();

            foreach (var saleDto in salesDtos)
            {
                Sale currentSale = new Sale()
                {
                    CarId = saleDto.CarId,
                    CustomerId = saleDto.CustomerId,
                    Discount = saleDto.Discount
                };

                sales.Add(currentSale);
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";


        }
        //T06
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var exportorderedCustomers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToArray();


            var export = JsonConvert.SerializeObject(exportorderedCustomers, Formatting.Indented);


            return export;
        }
        //T07
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var toyotaCarsExport = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToArray();

            var result = JsonConvert.SerializeObject(toyotaCarsExport, Formatting.Indented);

            return result;
        }
        //T08
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliersExport = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            var result = JsonConvert.SerializeObject(localSuppliersExport, Formatting.Indented);

            return result;
        }
        //T09
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsExport = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TravelledDistance = c.TravelledDistance
                    },

                    parts = c.PartCars
                        .Select(pc => new
                        {
                            Name = pc.Part.Name,
                            Price = $"{pc.Part.Price:F2}"
                        })
                })
                .ToArray();

            var result = JsonConvert.SerializeObject(carsExport, Formatting.Indented);
            return result;
        }
        //T10
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {

            var customerExport = context
                .Customers
                .Where(c => c.Sales.Any(s => s.Car != null))
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count(s => s.Car != null),
                    spentMoney = c.Sales
                        .SelectMany(s => s.Car.PartCars)
                        .Sum(pc => pc.Part.Price)

                })
                .OrderByDescending(c => c.spentMoney)
                .ThenByDescending(c => c.boughtCars)
                .ToList();

            var result = JsonConvert.SerializeObject(customerExport,Formatting.Indented);

            return result;
        }
        //T11
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var exportSales = context.Sales
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    customerName = s.Customer.Name,
                    Discount = $"{s.Discount:F2}",
                    price = $"{s.Car.PartCars.Sum(pc => pc.Part.Price)}",
                    priceWithDiscount = 
                        $@"{s.Car.PartCars.Sum(p => p.Part.Price)
                        - s.Car.PartCars.Sum(p => p.Part.Price) * s.Discount / 100:F2}"


                })
                .Take(10)
                .ToArray();
            var result = JsonConvert.SerializeObject(exportSales,Formatting.Indented);
            return result;
        }

        private static void ImportInfoFromFile(string fileName)
        {
            filePath = $"../../../Datasets/{fileName}.json";
        }

        private static void SetExportFilePath(string fileName)
        {
            filePath = $"../../../Results/{fileName}.json";
        }
    }
}
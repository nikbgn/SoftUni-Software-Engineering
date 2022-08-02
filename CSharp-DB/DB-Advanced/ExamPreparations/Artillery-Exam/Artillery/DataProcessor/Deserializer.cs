namespace Artillery.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage =
                "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportCountryModel[]),
                new XmlRootAttribute("Countries"));

            using var reader = new StringReader(xmlString);

            var countryDTOs = serializer.Deserialize(reader) as ImportCountryModel[];

            var countries = new List<Country>();

            foreach (var cDto in countryDTOs)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Country country = new Country()
                {
                    CountryName = cDto.CountryName,
                    ArmySize = cDto.ArmySize
                };


                countries.Add(country);

                sb.AppendLine(String.Format(SuccessfulImportCountry,country.CountryName,country.ArmySize));
            }

            context.Countries.AddRange(countries);
            context.SaveChanges();
            return sb.ToString().TrimEnd();

        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportManufacturerModel[]),
                new XmlRootAttribute("Manufacturers"));

            using var reader = new StringReader(xmlString);

            var manufacturerDTOs = serializer.Deserialize(reader) as ImportManufacturerModel[];

            var manufacturers = new List<Manufacturer>();


            foreach (var mDto in manufacturerDTOs)
            {
                if (!IsValid(mDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Manufacturer m = new Manufacturer()
                {
                    ManufacturerName = mDto.ManufacturerName,
                    Founded = mDto.Founded
                };

                if(manufacturers.Any(j => j.ManufacturerName == m.ManufacturerName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                manufacturers.Add(m);

                var finalInfo = m
                    .Founded.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var currManufacturerCountry = finalInfo.Last();

                var currManufacturerCity = finalInfo[finalInfo.Length - 2];

                var toOutput = $"{currManufacturerCity}, {currManufacturerCountry}";

                sb.AppendLine(String.Format(SuccessfulImportManufacturer, m.ManufacturerName, toOutput));

            }

            context.Manufacturers.AddRange(manufacturers);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportShellModel[]),
                new XmlRootAttribute("Shells"));

            using var reader = new StringReader(xmlString);

            var shellDTOs = serializer.Deserialize(reader) as ImportShellModel[];

            var shells = new List<Shell>();

            foreach (var sDto in shellDTOs)
            {
                if (!IsValid(sDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Shell currShell = new Shell()
                {
                    Caliber = sDto.Caliber,
                    ShellWeight = sDto.ShellWeight
                };

                shells.Add(currShell);

                sb.AppendLine(String.Format(SuccessfulImportShell, currShell.Caliber, currShell.ShellWeight));

            }

            context.Shells.AddRange(shells);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var gunDTOs = JsonConvert.DeserializeObject<ImportGunModel[]>(jsonString);

            var guns = new List<Gun>();

            foreach (var gDto in gunDTOs)
            {
                if (!IsValid(gDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }


                object gunTypeObj;

                bool isGunValid = Enum.TryParse(typeof(GunType), gDto.GunType, out gunTypeObj);

                if (!isGunValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Gun currGun = new Gun()
                {
                    ManufacturerId = gDto.ManufacturerId,
                    GunWeight = gDto.GunWeight,
                    BarrelLength = gDto.BarrelLength,
                    NumberBuild = gDto.NumberBuild,
                    Range = gDto.Range,
                    GunType = (GunType)gunTypeObj,
                    ShellId = gDto.ShellId
                };

                foreach (var cDto in gDto.Countries)
                {
                    var cGun = new CountryGun()
                    {
                        Gun = currGun,
                        CountryId = cDto.Id
                    };

                    currGun.CountriesGuns.Add(cGun);
                }

                sb.AppendLine(String.Format(SuccessfulImportGun, currGun.GunType, currGun.GunWeight, currGun.BarrelLength));
                guns.Add(currGun);
            }

            context.Guns.AddRange(guns);
            context.SaveChanges();



            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}

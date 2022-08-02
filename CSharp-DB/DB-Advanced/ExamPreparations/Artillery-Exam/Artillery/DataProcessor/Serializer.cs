
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            var shells = context
                .Shells
                .Where(s => s.ShellWeight > shellWeight)
                .ToArray()
                .Select(s => new
                {
                    ShellWeight = s.ShellWeight,
                    Caliber = s.Caliber,
                    Guns = s
                        .Guns
                        .Where(g => g.GunType.ToString() == "AntiAircraftGun")
                        .ToArray()
                        .Select(g => new
                        {
                            GunType = g.GunType.ToString(),
                            GunWeight = g.GunWeight,
                            BarrelLength = g.BarrelLength,
                            Range = g.Range > 3000 ? "Long-range" : "Regular range"
                        })
                        .OrderByDescending(g => g.GunWeight)
                        .ToArray()

                })
                .OrderBy(s => s.ShellWeight)
                .ToArray();

            var json = JsonConvert.SerializeObject(shells, Formatting.Indented);
            return json;
        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            ExportGunModel[] guns = context
                .Guns
                .Where(g => g.Manufacturer.ManufacturerName == manufacturer)
                .ToArray()
                .Select(g => new ExportGunModel()
                {
                    Manufacturer = g.Manufacturer.ManufacturerName,
                    GunType = g.GunType.ToString(),
                    BarrelLength = g.BarrelLength,
                    GunWeight = g.GunWeight,
                    Range = g.Range,
                    Countries = g
                        .CountriesGuns
                        .Where(cg => cg.Country.ArmySize > 4_500_000)
                        .ToArray()
                        .Select(cg => new ExportCountryModel()
                        {
                            Country = cg.Country.CountryName,
                            ArmySize = cg.Country.ArmySize
                        })
                        .OrderBy(cg => cg.ArmySize)
                        .ToArray()
                })
                .OrderBy(g => g.BarrelLength)
                .ToArray();

            XmlSerializer serializer =
                new XmlSerializer(typeof(ExportGunModel[]),
                new XmlRootAttribute("Guns"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, guns, ns);

            var result = writer.ToString();

            return result;
        }
    }
}

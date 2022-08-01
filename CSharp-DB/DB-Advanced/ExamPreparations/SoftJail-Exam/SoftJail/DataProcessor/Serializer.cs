namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.DataProcessor.ExportDto;
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportPrisonersByCells(SoftJailDbContext context, int[] ids)
        {
            var prisoners = context
                .Prisoners
                .ToArray()
                .Where(p => ids.Contains(p.Id))
                .Select(p => new
                {
                    Id = p.Id,
                    Name = p.FullName,
                    CellNumber = p.Cell.CellNumber,
                    Officers = p.PrisonerOfficers
                    .Select(po => new
                    {
                        OfficerName = po.Officer.FullName,
                        Department = po.Officer.Department.Name
                    })
                    .OrderBy(o => o.OfficerName)
                    .ToArray(),
                    TotalOfficerSalary = Math.Round(p.PrisonerOfficers.Sum(po => po.Officer.Salary), 2)
                })
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Id)
                .ToArray();

            var json = JsonConvert.SerializeObject(prisoners, Formatting.Indented);

            return json;

        }

        public static string ExportPrisonersInbox(SoftJailDbContext context, string prisonersNames)
        {
            var names = prisonersNames.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();

            ExportPrisonersModel[] prisoners = context
                .Prisoners
                .ToArray()
                .Where(p => names.Contains(p.FullName))
                .Select(p => new ExportPrisonersModel()
                {
                    Id = p.Id,
                    Name = p.FullName,
                    IncarcerationDate = p.IncarcerationDate.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture),
                    EncryptedMessages = p.Mails.Select(m => new EncryptedMessageModel()
                    {
                        Description = String.Join("", m.Description.Reverse())
                    }).ToArray()
                })
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Id)
                .ToArray();

            XmlSerializer serializer =
                new XmlSerializer(typeof(ExportPrisonersModel[]),
                new XmlRootAttribute("Prisoners"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, prisoners, ns);

            var result = writer.ToString();

            return result;
        }
    }
}
namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var theatres = context
                .Theatres
                .ToArray()
                .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count > 20)
                .Select(t => new
                {
                    Name = t.Name,
                    Halls = t.NumberOfHalls,
                    TotalIncome = t.Tickets.Where(tr => tr.RowNumber >= 1 && tr.RowNumber <= 5).Select(x => x.Price).Sum(),
                    Tickets = t.Tickets.Where(tr => tr.RowNumber >= 1 && tr.RowNumber <= 5)
                        .Select(t => new
                        {
                            Price = t.Price,
                            RowNumber = t.RowNumber
                        })
                        .ToArray()
                        .OrderByDescending(t => t.Price)
                })
                .OrderByDescending(t => t.Halls)
                .ThenBy(t => t.Name)
                .ToArray();

            var json = JsonConvert.SerializeObject(theatres,Formatting.Indented);
            return json;
        }

        public static string ExportPlays(TheatreContext context, double rating)
        {
            ExportPlaysModel[] plays = context
                .Plays
                .ToArray()
                .Where(p => p.Rating <= rating)
                .Select(p => new ExportPlaysModel()
                {
                    Title = p.Title,
                    Duration = p.Duration.ToString(),
                    Rating = p.Rating == 0 ? "Premier" : p.Rating.ToString(),
                    Genre = p.Genre.ToString(),
                    Actors = p.Casts.Where(a => a.IsMainCharacter).Select(a => new ExportActorModel()
                    {
                        FullName = a.FullName,
                        MainCharacter = $"Plays main character in '{p.Title}'."
                    })
                    .OrderByDescending(a => a.FullName)
                    .ToArray()
                })
                .OrderBy(p => p.Title)
                .ThenByDescending(p => p.Genre)
                .ToArray();


            XmlSerializer serializer =
                new XmlSerializer(typeof(ExportPlaysModel[]),
                new XmlRootAttribute("Plays"));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var writer = new StringWriter();

            serializer.Serialize(writer, plays, ns);

            var result = writer.ToString();

            return result;


        }
    }
}

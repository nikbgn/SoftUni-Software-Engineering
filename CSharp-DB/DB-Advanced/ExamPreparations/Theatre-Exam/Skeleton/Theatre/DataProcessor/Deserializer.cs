namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {

            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportPlaysModel[]),
                new XmlRootAttribute("Plays"));

            using var reader = new StringReader(xmlString);

            var playsDTOS = serializer.Deserialize(reader) as ImportPlaysModel[];

            var plays = new List<Play>();

            foreach (var play in playsDTOS)
            {
                if (!IsValid(play))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                TimeSpan resultTimespan;
                var timespanVerify = TimeSpan
                    .TryParseExact(play.Duration, "c", CultureInfo.InvariantCulture, out resultTimespan);
                
                if (!timespanVerify)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if(resultTimespan.Hours < 1)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                object genreVerified;
                var genreVerify = Enum
                    .TryParse(typeof(Genre),
                    play.Genre, out genreVerified);

                if (!genreVerify)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play currPlay = new Play()
                {
                    Title = play.Title,
                    Duration = resultTimespan,
                    Rating = play.Rating,
                    Genre = (Genre)genreVerified,
                    Description = play.Description,
                    Screenwriter = play.Screenwriter
                };

                plays.Add(currPlay);
                sb.AppendLine(String.Format(SuccessfulImportPlay,currPlay.Title,currPlay.Genre.ToString(),currPlay.Rating));


            }
            context.Plays.AddRange(plays);
            context.SaveChanges();

            return sb.ToString();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {

            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportCastsModel[]),
                new XmlRootAttribute("Casts"));

            using var reader = new StringReader(xmlString);

            var castsDTOs = serializer.Deserialize(reader) as ImportCastsModel[];

            var casts = new List<Cast>();

            foreach (var cast in castsDTOs)
            {
                if (!IsValid(cast))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Cast currCast = new Cast()
                {
                    FullName = cast.FullName,
                    IsMainCharacter = cast.IsMainCharacter,
                    PhoneNumber = cast.PhoneNumber,
                    PlayId = cast.PlayId
                };

                casts.Add(currCast);
                string isMainOrNot = currCast.IsMainCharacter ? "main" : "lesser";
                sb.AppendLine(String.Format(SuccessfulImportActor,currCast.FullName,isMainOrNot));
            }
            context.Casts.AddRange(casts);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var projectionsDTOs = JsonConvert.DeserializeObject<ImportProjectionsModel[]>(jsonString);

            var projections = new List<Theatre>();

            foreach (var pDTO in projectionsDTOs)
            {
                if (!IsValid(pDTO))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Theatre t = new Theatre()
                {
                    Name = pDTO.Name,
                    NumberOfHalls = pDTO.NumberOfHalls,
                    Director = pDTO.Director
                };

                foreach (var ticket in pDTO.Tickets)
                {
                    if (!IsValid(ticket))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Ticket currTicket = new Ticket()
                    {
                        Price = ticket.Price,
                        RowNumber = ticket.RowNumber,
                        PlayId = ticket.PlayId
                    };

                    t.Tickets.Add(currTicket);

                }

                sb.AppendLine(String.Format(SuccessfulImportTheatre,t.Name,t.Tickets.Count));
                projections.Add(t);
            }
            context.Theatres.AddRange(projections);
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

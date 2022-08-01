namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var dcDtos = JsonConvert.DeserializeObject<ImportDepartmentsCellsModel[]>(jsonString);

            var validDepartments = new List<Department>();

            foreach (var dcDto in dcDtos)
            {
                if (!IsValid(dcDto))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                if (!dcDto.Cells.Any())
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                if (dcDto.Cells.Any(c => !IsValid(c)))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                Department currDepartment = new Department()
                {
                    Name = dcDto.Name,
                };

                foreach (var cellDto in dcDto.Cells)
                {
                    Cell currCell = new Cell()
                    {
                        CellNumber = cellDto.CellNumber,
                        HasWindow = cellDto.HasWindow
                    };

                    currDepartment.Cells.Add(currCell);
                }

                validDepartments.Add(currDepartment);
                sb.AppendLine($"Imported {currDepartment.Name} with {currDepartment.Cells.Count} cells");

            }

            context.Departments.AddRange(validDepartments);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            var pmDtos = JsonConvert.DeserializeObject<ImportPrisonersMailsModel[]>(jsonString);

            var validPrisoners = new List<Prisoner>();


            foreach (var pmDto in pmDtos)
            {
                if (!IsValid(pmDto))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                if (!IsValid(pmDto.Mails.Any(a => !IsValid(a.Address))))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                DateTime incarcerationDate;
                bool isIncarcerationDateValid = DateTime.TryParseExact(pmDto.IncarcerationDate, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out incarcerationDate);

                if (!isIncarcerationDateValid)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                DateTime? releaseDate = null;
                if (!String.IsNullOrEmpty(pmDto.ReleaseDate))
                {
                    DateTime releaseDateValue;
                    bool isReleaseDateValid =
                        DateTime.TryParseExact(pmDto.ReleaseDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out releaseDateValue);

                    if (!isReleaseDateValid)
                    {
                        sb.AppendLine("Invalid Data");
                        continue;
                    }
                    releaseDate = releaseDateValue;

                }

                Prisoner currPrisoner = new Prisoner()
                {
                    FullName = pmDto.FullName,
                    Nickname = pmDto.NickName,
                    Age = pmDto.Age,
                    IncarcerationDate = incarcerationDate,
                    ReleaseDate = releaseDate,
                    Bail = pmDto.Bail,
                    CellId = pmDto.CellId
                };

                bool mailsValidCheck = true;
                foreach (var mailDto in pmDto.Mails)
                {
                    if (!IsValid(mailDto))
                    {
                        mailsValidCheck = false;
                        sb.AppendLine("Invalid Data");
                        continue;
                    }

                    Mail validMail = new Mail()
                    {
                        Description = mailDto.Description,
                        Sender = mailDto.Sender,
                        Address = mailDto.Address
                    };

                    currPrisoner.Mails.Add(validMail);
                }

                if (mailsValidCheck == false)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                validPrisoners.Add(currPrisoner);
                sb.AppendLine($"Imported {currPrisoner.FullName} {currPrisoner.Age} years old");

            }

            context.Prisoners.AddRange(validPrisoners);
            context.SaveChanges();

            return sb.ToString().TrimEnd();

        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer serializer = new
                XmlSerializer(typeof(ImportOfficerPrisonerModel[]),
                new XmlRootAttribute("Officers"));

            using var reader = new StringReader(xmlString);

            var opDtos = serializer.Deserialize(reader) as ImportOfficerPrisonerModel[];

            var officers = new List<Officer>();

            foreach (var officerDto in opDtos)
            {
                if (!IsValid(officerDto))
                {
                    sb.AppendLine(GlobalMessages.InvalidData);
                    continue;
                }

                //Validate position and weapon

                object positionObj;

                bool isPositionValid = Enum.TryParse(typeof(Position), officerDto.Position, out positionObj);

                if (!isPositionValid)
                {
                    sb.AppendLine(GlobalMessages.InvalidData);
                    continue;
                }

                object weaponObj;

                bool isWeaponValid = Enum.TryParse(typeof(Weapon), officerDto.Weapon, out weaponObj);

                if (!isWeaponValid)
                {
                    sb.AppendLine(GlobalMessages.InvalidData);
                    continue;
                }


                Officer officer = new Officer()
                {
                    FullName = officerDto.Name,
                    Salary = officerDto.Money,
                    Position = (Position)positionObj,
                    Weapon = (Weapon)weaponObj,
                    DepartmentId = officerDto.DepartmentId
                };

                foreach (var prisonerDto in officerDto.Prisoners)
                {
                    OfficerPrisoner op = new OfficerPrisoner()
                    {
                        Officer = officer,
                        PrisonerId = prisonerDto.Id
                    };

                    officer.OfficerPrisoners.Add(op);

                }

                officers.Add(officer);
                sb.AppendLine(String.Format(GlobalMessages.ImportOfficerSucessMesage, officer.FullName,officer.OfficerPrisoners.Count));

            }
            context.Officers.AddRange(officers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}
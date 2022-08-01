namespace SoftJail.Data
{
    public static class ValidationConstants
    {
        public const int PrisonerFullNameMaxLength = 20;
        public const int PrisonerFullNameMinLength = 3;

        public const int PrisonerMinAge = 18;
        public const int PrisonerMaxAge = 65;

        public const int OfficerFullNameMaxLength = 30;
        public const int OfficerFullNameMinLength = 3;

        public const int DepartmentNameMaxLength = 25;
        public const int DepartmentNameMinLength = 3;

        public const int CellNumberMinValue = 1;
        public const int CellNumberMaxValue = 1000;

        public const string AddressRegex = @"^([A-Za-z\s0-9]+?)(\sstr\.)$";
        public const string NicknameRegex = @"^(The\s)[A-Z][a-z]+$";

        public const string BailMinValue = "0";
        public const string BailMaxValue = "79228162514264337593543950335";

    }
}

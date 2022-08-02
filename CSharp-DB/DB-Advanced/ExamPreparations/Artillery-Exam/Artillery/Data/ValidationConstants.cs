namespace Artillery.Data
{
    public static class ValidationConstants
    {
        public const int CountryNameMinLength = 4;
        public const int CountryNameMaxLength = 60;

        public const int ManufacturerNameMinLength = 4;
        public const int ManufacturerNameMaxLength = 40;
        public const int ManufacturerFoundedMinLength = 10;
        public const int ManufacturerFoundedMaxLength = 100;

        public const int CaliberMinLength = 4;
        public const int CaliberMaxLength = 30;

        public const int ArmySizeMinRange = 50_000;
        public const int ArmySizeMaxRange = 10_000_000;

        public const double ShellWeightMin = 2;
        public const double ShellWeightMax = 1_680;

    }
}

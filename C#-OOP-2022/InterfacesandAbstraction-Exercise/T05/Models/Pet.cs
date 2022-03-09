namespace T05
{
    public class Pet : IIdentifiable, IBirthdayable
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDay = birthDate;
        }

        public string Name { get; private set; }
        public string Id { get; set; } //Won't be used!
        public string BirthDay { get; private set; }
    }
}
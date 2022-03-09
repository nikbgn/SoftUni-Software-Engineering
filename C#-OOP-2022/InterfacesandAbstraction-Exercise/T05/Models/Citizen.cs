namespace T05
{
    public class Citizen : IIdentifiable, IBirthdayable
    {
        public Citizen(string id, string name, int age, string birthDay)
        {
            Id = id;
            Name = name;
            Age = age;
            BirthDay = birthDay;
        }

        public string Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string BirthDay { get; private set; }
    }
}

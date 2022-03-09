namespace T04
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
    }
}

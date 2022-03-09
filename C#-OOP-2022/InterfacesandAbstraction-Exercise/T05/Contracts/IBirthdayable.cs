namespace T05
{
    public interface IBirthdayable
    {
        public string Name { get;}
        public string BirthDay { get; } //Birthday will be given as a string in the format xx/xx/xxxx , this is why I don't use DateTime
    }
}

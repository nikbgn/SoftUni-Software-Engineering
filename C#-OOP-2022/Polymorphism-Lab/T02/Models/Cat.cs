namespace Animals
{
    using System.Text;
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"I am {this.Name} and my fovourite food is {this.FavouriteFood}");
            sb.AppendLine("MEEOW");
            return sb.ToString().TrimEnd();
        }
    }
}

namespace Animals
{
    using System.Text;
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }


        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"I am {this.Name} and my fovourite food is {this.FavouriteFood}");
            sb.AppendLine("DJAAF");
            return sb.ToString().TrimEnd();
        }
    }
}

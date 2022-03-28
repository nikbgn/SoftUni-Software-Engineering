namespace Gym
{
    using Gym.Core;
    using Gym.Core.Contracts;
    public class StartUp
    {
        public static void Main()
        {
            // Forgot that I have OutputMessages.cs ... lol
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}

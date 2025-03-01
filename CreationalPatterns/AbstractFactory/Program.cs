using AbstractFactory.Abstraction;
using AbstractFactory.Client;
using AbstractFactory.Implementation.Mac;
using AbstractFactory.Implementation.Windows;

namespace AbstractFactory
{
    public class Program
    {
        public enum Platform
        {
            Windows,
            Mac
        }
        static void Main(string[] args)
        {
            var currentPlatform = Platform.Windows;

            IComponentFactory factory = (currentPlatform) switch
            {
                Platform.Windows => new WindowsComponentFactory(),
                Platform.Mac => new MacComponentFactory(),
                _ => throw new InvalidOperationException("Given platform not supported")
            };

            var app = new Application(factory);
            app.Run();

        }
    }
}

using FactoryMethod.Abstraction;
using FactoryMethod.Client;
using FactoryMethod.Implementation.Web;
using FactoryMethod.Implementation.Windows;

namespace FactoryMethod
{
    internal class Program
    {
        public enum Platform
        {
            Web,
            WindowsForm
        }

        static void Main(string[] args)
        {
            var currentPlatform = Platform.WindowsForm;

            Dialog dialog = currentPlatform switch
            {
                Platform.Web => new WebDialog(),
                Platform.WindowsForm => new WindowsDialog(),
                _ => throw new InvalidOperationException("Given platform is not supported")
            };

            var app = new Application(dialog);
            app.Run();

            Console.ReadKey();
        }
    }
}

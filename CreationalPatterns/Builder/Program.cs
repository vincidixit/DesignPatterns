using Builder.Abstraction;
using Builder.Client;
using Builder.Implementation;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            application.BuildPizzas();
        }
    }
}

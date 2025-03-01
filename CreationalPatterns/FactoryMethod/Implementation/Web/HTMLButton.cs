using FactoryMethod.Abstraction;

namespace FactoryMethod.Implementation.Web
{
    public class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine($"Rendering {this.GetType().Name}");
        }
    }
}
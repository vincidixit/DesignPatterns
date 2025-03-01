using FactoryMethod.Abstraction;

namespace FactoryMethod.Implementation.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine($"Rendering {GetType().Name}");
        }
    }
}
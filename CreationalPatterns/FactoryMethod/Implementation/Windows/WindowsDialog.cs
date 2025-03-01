using FactoryMethod.Abstraction;

namespace FactoryMethod.Implementation.Windows
{
    public class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
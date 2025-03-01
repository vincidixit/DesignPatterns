using FactoryMethod.Abstraction;

namespace FactoryMethod.Implementation.Web
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}
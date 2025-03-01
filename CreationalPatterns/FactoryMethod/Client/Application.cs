using FactoryMethod.Abstraction;

namespace FactoryMethod.Client
{
    public class Application
    {
        private readonly Dialog _dialog;
        public Application(Dialog dialog)
        {
            _dialog = dialog;
        }

        public void Run()
        {
            _dialog.Render();
        }

    }
}
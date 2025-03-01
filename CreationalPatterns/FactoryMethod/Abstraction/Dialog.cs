namespace FactoryMethod.Abstraction
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public virtual void Render()
        {
            Console.WriteLine($"Rendering {this.GetType().Name}");
            IButton button = CreateButton();
            button.Render();
        }

    }
}
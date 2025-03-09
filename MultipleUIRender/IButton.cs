namespace MultipleUIRender
{
    public interface IButton
    {
        void Render();
    }
    public class MobileButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Mobile Button here.");
        }
    }
    public class DesktopButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Desktop Button here. ");
        }
    }
}

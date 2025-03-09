namespace MultipleUIRender
{
    public interface IText
    {
        void Render();
    }
    public class MobileText : IText
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mobile text");
        }
    }

    public class DesktopText : IText
    {
        public void Render()
        {
            Console.WriteLine("Rendering Desktop text");
        }
    }
}

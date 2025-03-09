namespace MultipleUIRender
{

    //this is the abstract factory .
    public interface IUComponentFactory
    {
        IButton CreateButton();
        IText CreateText();
    }

    public class MobileUIComponentFactory : IUComponentFactory
    {
        public IButton CreateButton()=> new MobileButton();

        public IText CreateText()=>new MobileText();
    }

    public class DesktopUIComponentFactory : IUComponentFactory
    {
        public IButton CreateButton()=>new DesktopButton();
        public IText CreateText() =>new DesktopText();
    }
}

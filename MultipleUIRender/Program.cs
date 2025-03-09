using MultipleUIRender;

Console.WriteLine("mobile UI  factory ..");

IUComponentFactory mobileFactory = new MobileUIComponentFactory();
var mobilebutton= mobileFactory.CreateButton();
var mobiletext= mobileFactory.CreateText();
mobilebutton.Render();
mobiletext.Render();
Console.WriteLine("Desktop UI Factory ..");

IUComponentFactory Desktopfactory = new DesktopUIComponentFactory();
var deskButton= Desktopfactory.CreateButton();
var deskText=Desktopfactory.CreateText();
deskButton.Render();
deskText.Render();


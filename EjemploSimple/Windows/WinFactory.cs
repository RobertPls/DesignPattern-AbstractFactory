using EjemploSimple.Interfaces;

namespace EjemploSimple.Windows
{
    public class WinFactory : GUIFactory
    {
        public Button createButton()
        {
            return new WinButton();
        }

        public Checkbox createCheckBox()
        {
            return new WinCheckbox();
        }
    }
}

using EjemploSimple.Interfaces;

namespace EjemploSimple.Mac
{
    public class MacFactory : GUIFactory
    {
        public Button createButton()
        {
            return new MacButton();
        }

        public Checkbox createCheckBox()
        {
            return new MacCheckbox();
        }
    }
}

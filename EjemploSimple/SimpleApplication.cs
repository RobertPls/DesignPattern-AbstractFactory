using EjemploSimple.Interfaces;

namespace EjemploSimple
{
    public class SimpleApplication
    {
        public GUIFactory factory;
        public Button button;
        public Checkbox checkbox;

        public SimpleApplication (GUIFactory factory)
        {
            this.factory = factory;
        }
        public void createUI()
        {
            this.button = factory.createButton ();
            this.checkbox = factory.createCheckBox ();
        }
         
        public void paint()
        {
            this.button.paint ();
        }
    }
}

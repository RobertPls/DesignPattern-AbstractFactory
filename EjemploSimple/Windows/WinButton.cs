using EjemploSimple.Interfaces;

namespace EjemploSimple.Windows
{
    internal class WinButton : Button
    {
        public void paint()
        {
            Console.WriteLine("Boton Windows activado");
        }
    }
}

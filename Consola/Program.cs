using EjemploSimple.Interfaces;
using EjemploSimple.Mac;
using EjemploSimple.Windows;
using EjemploSimple;
using EjemploReal.Interfaces;
using EjemploReal.Contabilidad;
using EjemploReal.Ventas;
using EjemploReal;

class Program
{
    
    public static void Main(string[] args)
    {
        ejecutarAplicacionCasoReal();
    }

    public static void ejecutarAplicacionSimple()
    {
        GUIFactory factory;
        string configuration1 = "Windows";
        string configuration2 = "Mac";

        string configOs = configuration2;

        if (configOs == "Windows")
        {
            factory = new WinFactory();
        }
        else if (configOs == "Mac")
        {
            factory = new MacFactory();
        }
        else
        {
            throw new Exception("Sistema Operativo No Conocido");
        }

        SimpleApplication app = new SimpleApplication(factory);
        app.createUI();
        app.paint();
    }


    public static void ejecutarAplicacionCasoReal()
    {
        IReporteFactory factory;
        string configuration1 = "Ventas";
        string configuration2 = "Contabilidad";

        string configOs = configuration1;

        if (configOs == "Ventas")
        {
            factory = new VentaReporteFactory();
        }
        else if (configOs == "Contabilidad")
        {
            factory = new ContabilidadReporteFactory();
        }
        else
        {
            throw new Exception("Area No Conocida");
        }

        Application app = new Application(factory);

        app.generarReporteWord();
        app.generarReportePdf();
        app.generarReportePowerPoint();
    }
}
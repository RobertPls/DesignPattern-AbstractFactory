using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal
{
    public class Application
    {
        public IReporteFactory factory;
        public IReportePdf reportePdf;
        public IReporteWord reporteWord;
        public IReportePowerPoint reportePowerPoint;

        public Application(IReporteFactory factory)
        {
            this.factory = factory;
        }

        public void generarReporteWord()
        {
            this.reporteWord = factory.CrearReporteWord();
            string reporte = this.reporteWord.obtenerReporte();
            Console.WriteLine(reporte);
        }

        public void generarReportePdf()
        {
            this.reportePdf = factory.CrearReportePdf();
            string reporte = this.reportePdf.obtenerReporte();
            Console.WriteLine(reporte);
        }

        public void generarReportePowerPoint()
        {
            this.reportePowerPoint = factory.CrearReportePowerPoint();
            string reporte = this.reportePowerPoint.obtenerReporte();
            Console.WriteLine(reporte);
        }
    }
}

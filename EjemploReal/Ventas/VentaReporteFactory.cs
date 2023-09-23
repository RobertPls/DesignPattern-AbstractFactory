using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Ventas
{
    public class VentaReporteFactory : IReporteFactory
    {
        public IReportePdf CrearReportePdf()
        {
            return new VentaReportePdf();
        }

        public IReportePowerPoint CrearReportePowerPoint()
        {
            return new VentaReportePowerPoint();
        }

        public IReporteWord CrearReporteWord()
        {
            return new VentaReporteWord();
        }
    }
}

using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Ventas
{
    public class VentaReportePowerPoint : IReportePowerPoint
    {
        public string obtenerReporte()
        {
            return "Reporte Ventas Generado en power point";
        }
    }
}

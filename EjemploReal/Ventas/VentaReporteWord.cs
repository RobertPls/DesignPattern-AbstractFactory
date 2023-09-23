using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Ventas
{
    public class VentaReporteWord : IReporteWord
    {
        public string obtenerReporte()
        {
            return "Reporte Ventas Generado en word";
        }
    }
}

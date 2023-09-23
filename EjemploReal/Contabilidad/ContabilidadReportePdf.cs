using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Contabilidad
{
    public class ContabilidadReportePdf : IReportePdf
    {
        public string obtenerReporte()
        {
            return "Reporte Contabilidad Generado en pdf";
        }
    }
}

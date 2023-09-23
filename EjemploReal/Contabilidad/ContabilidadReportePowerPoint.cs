using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Contabilidad
{
    public class ContabilidadReportePowerPoint : IReportePowerPoint
    {
        public string obtenerReporte()
        {
            return "Reporte contabilidad Generado en power point";
        }
    }
}

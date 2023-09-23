using EjemploReal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploReal.Contabilidad
{
    public class ContabilidadReporteFactory : IReporteFactory
    {
        public IReportePdf CrearReportePdf()
        {
            return new ContabilidadReportePdf();
        }

        public IReportePowerPoint CrearReportePowerPoint()
        {
            return new ContabilidadReportePowerPoint();
        }

        public IReporteWord CrearReporteWord()
        {
            return new ContabilidadReporteWord();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class PromedioProgramacion:Promedio
    {
        
        public double CalcularPromedio()
        {

            double nota1 = Eval1 * 0.15;
            double nota2 = Eval2 * 0.012;
            double nota3 = Eval3 * 0.0225;
            double notaActi = NotaActi * 0.10;
            return Eval1 * nota1 + nota2 +  nota3 + notaActi/4;
        }
    }
}

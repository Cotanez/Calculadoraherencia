using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraherencia
{
    internal class Dividir:Operacion
    {
        // Metodo que recibe parametros.
        public double operar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = Valor1 / Valor2;
            return Resultado;
        }
        // Sobrecarga del metodo operar.
        public double operar()
        {
            Resultado = Valor1 / Valor2;
            return Resultado;
        }
    }
}

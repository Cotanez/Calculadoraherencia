using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraherencia
{
    internal class Operacion
    {
        // Atributos, campos, el como es.
        double valor1;
        double valor2;
        double resultado;

        // Encapsulamiento de las propiedades.
        public double Valor1 { get => valor1; set => valor1 = value; }
        public double Valor2 { get => valor2; set => valor2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}

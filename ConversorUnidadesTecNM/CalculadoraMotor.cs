using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidadesTecNM
{
    public class CalculadoraMotor
    {
        //metodo que convierte a dolares
        public double Convertir(double cantidad)
        {
            return cantidad / 20.0;
        }

        //metodo sobrecargado que recibe lo mismo pero retorna euro
        public double Convertir(double cantidad, string tipoMoneda)
        {
            if (tipoMoneda == "Euro")
            {
                return cantidad / 21.50;
            }
            return cantidad / 20.0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
/**
 * @author Fernando Calmet <fercalmet@gmail.com>
 * @link https://www.khanakat.com
 */
namespace PrincipiosSOLID.SRP
{
    class Impuesto
    {
        public static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(Empleado empleado)
        {
            double impuesto = CalcularImpuesto(empleado);
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", impuesto, empleado.Nombre);
        }
    }
}

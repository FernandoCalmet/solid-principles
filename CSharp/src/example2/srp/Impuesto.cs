using System;

namespace CSharp.src.example2.srp
{
    public class Impuesto
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
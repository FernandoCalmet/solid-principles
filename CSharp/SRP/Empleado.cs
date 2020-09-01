using System;
using System.Collections.Generic;
using System.Text;
/**
 * @author Fernando Calmet <fercalmet@gmail.com>
 * @link https://www.khanakat.com
 */
namespace PrincipiosSOLID.SRP
{
    class Empleado
    {
        private String nombre;
        private String puesto;
        private int edad;
        private double sueldo;

        public Empleado(string nombre, string puesto, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",nombre,puesto,edad,sueldo);
        }
    }
}

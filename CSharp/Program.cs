using System;
using System.Collections.Generic;
/**
* @author Fernando Calmet <fercalmet@gmail.com>
* @link https://www.khanakat.com
*/
namespace PrincipiosSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Principio de responsabilidad unica (SRP) */
            SRP.Empleado empleado_srp = new SRP.Empleado("Fernando", "Programador", 30, 3000.55);           
            SRP.Impuesto.CalcularImpuesto(empleado_srp);
            SRP.Impuesto.PagarImpuesto(empleado_srp);

            /* Principio de abierto y cerrado (OCP) */
            List<OCP.BaseInventario> misProductos = new List<OCP.BaseInventario>
            {
                new OCP.InventarioBebidas(new OCP.Producto("Gaseosa", 2, 6.55)),
                new OCP.InventarioAlimentos(new OCP.Producto("Camote", 1, 2.33)),
                new OCP.InventarioAlimentos(new OCP.Producto("Papa", 1, 1.00)),
                new OCP.InventarioBebidas(new OCP.Producto("Jugo", 2, 4.70)),
                new OCP.InventarioAlimentos(new OCP.Producto("Arroz", 1, 3.00)),
                new OCP.InventarioBebidas(new OCP.Producto("Cerveza", 2, 6.35))
            };
            OCP.Tienda tienda = new OCP.Tienda(misProductos);
            tienda.calcularInventario();

            /* Principio de sustitucion de Liskov (LSP) */
            LSP.Principal noticiero = new LSP.Noticiero("Hola desde el noticiero");
            noticiero.Muestra();
            LSP.Principal radio = new LSP.Radio("Hola desde la radio");
            radio.Muestra(); 
            LSP.Principal sustitucion = new LSP.Radio("Hola desde la radio x2");
            sustitucion.Muestra();

            /* Principio de segregacion de interface (ISP) */
            ISP.cMultiAvanzado mAvanzado = new ISP.cMultiAvanzado();
            mAvanzado.Escanear();
            mAvanzado.Faxear();
            mAvanzado.Imprimir();
            mAvanzado.Telefono();
            ISP.cMultiSencillo mSencillo = new ISP.cMultiSencillo();
            mSencillo.Imprimir();
            mSencillo.Escanear();
            ISP.cTelefono mTelefono = new ISP.cTelefono();
            mTelefono.Telefono();
            mTelefono.Faxear();

            /* Principio de inversion de depedencias (DIP) */
            DIP.cAlmacen almacen = new DIP.cAlmacen();
            double total0 = 0;
            double total1 = 0;
            double total2 = 0;
            almacen.AdicionarProducto(new DIP.cProducto("Manzana", 0, 2.50));
            almacen.AdicionarProducto(new DIP.cProducto("Jugo de naranja", 1, 4));
            almacen.AdicionarProducto(new DIP.cProducto("Arroz", 0, 3.80));
            almacen.AdicionarProducto(new DIP.cProducto("Camiseta", 2, 30));
            almacen.AdicionarProducto(new DIP.cProducto("Pantalon", 2, 50.50));
            almacen.AdicionarProducto(new DIP.cProducto("Gaseosa", 1, 5.60));
            almacen.AdicionarProducto(new DIP.cProducto("Pan", 0, 1.20));
            DIP.cAuditor auditor = new DIP.cAuditor(almacen);
            total0 = auditor.totalAlimentos();
            Console.WriteLine("El total de alimentos es {0}", total0);
            total1 = auditor.totalBebidas();
            Console.WriteLine("El total de bebidas es {0}", total1);
            total2 = auditor.totalRopas();
            Console.WriteLine("El total de ropas es {0}", total2);
        }
    }
}

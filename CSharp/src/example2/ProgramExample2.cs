using System;
using System.Collections.Generic;

namespace CSharp.src.example2
{
    public class ProgramExample2
    {
        /* Principio de responsabilidad unica (SRP) */
        public void srpExample()
        {
            srp.Empleado empleado_srp = new srp.Empleado("Fernando", "Programador", 30, 3000.55);
            srp.Impuesto.CalcularImpuesto(empleado_srp);
            srp.Impuesto.PagarImpuesto(empleado_srp);
        }

        /* Principio de abierto y cerrado (OCP) */
        public void ocpExample()
        {
            List<ocp.BaseInventario> misProductos = new List<ocp.BaseInventario> {
                new ocp.InventarioBebidas (new ocp.Producto ("Gaseosa", 2, 6.55)),
                new ocp.InventarioAlimentos (new ocp.Producto ("Camote", 1, 2.33)),
                new ocp.InventarioAlimentos (new ocp.Producto ("Papa", 1, 1.00)),
                new ocp.InventarioBebidas (new ocp.Producto ("Jugo", 2, 4.70)),
                new ocp.InventarioAlimentos (new ocp.Producto ("Arroz", 1, 3.00)),
                new ocp.InventarioBebidas (new ocp.Producto ("Cerveza", 2, 6.35))
            };
            ocp.Tienda tienda = new ocp.Tienda(misProductos);
            tienda.calcularInventario();
        }

        /* Principio de sustitucion de Liskov (LSP) */
        public void lspExample()
        {
            lsp.Principal noticiero = new lsp.Noticiero("Hola desde el noticiero");
            noticiero.Muestra();
            lsp.Principal radio = new lsp.Radio("Hola desde la radio");
            radio.Muestra();
            lsp.Principal sustitucion = new lsp.Radio("Hola desde la radio x2");
            sustitucion.Muestra();
        }

        /* Principio de segregacion de interface (ISP) */
        public void ispExample()
        {
            isp.MultiAvanzado mAvanzado = new isp.MultiAvanzado();
            mAvanzado.Escanear();
            mAvanzado.Faxear();
            mAvanzado.Imprimir();
            mAvanzado.Telefonear();
            isp.MultiSencillo mSencillo = new isp.MultiSencillo();
            mSencillo.Imprimir();
            mSencillo.Escanear();
            isp.Telefono mTelefono = new isp.Telefono();
            mTelefono.Telefonear();
            mTelefono.Faxear();
        }

        /* Principio de inversion de depedencias (DIP) */
        public void dipExample()
        {
            dip.Almacen almacen = new dip.Almacen();
            double total0 = 0;
            double total1 = 0;
            double total2 = 0;
            almacen.AdicionarProducto(new dip.Producto("Manzana", 0, 2.50));
            almacen.AdicionarProducto(new dip.Producto("Jugo de naranja", 1, 4));
            almacen.AdicionarProducto(new dip.Producto("Arroz", 0, 3.80));
            almacen.AdicionarProducto(new dip.Producto("Camiseta", 2, 30));
            almacen.AdicionarProducto(new dip.Producto("Pantalon", 2, 50.50));
            almacen.AdicionarProducto(new dip.Producto("Gaseosa", 1, 5.60));
            almacen.AdicionarProducto(new dip.Producto("Pan", 0, 1.20));
            dip.Auditor auditor = new dip.Auditor(almacen);
            total0 = auditor.totalAlimentos();
            Console.WriteLine("El total de alimentos es {0}", total0);
            total1 = auditor.totalBebidas();
            Console.WriteLine("El total de bebidas es {0}", total1);
            total2 = auditor.totalRopas();
            Console.WriteLine("El total de ropas es {0}", total2);
        }
    }
}
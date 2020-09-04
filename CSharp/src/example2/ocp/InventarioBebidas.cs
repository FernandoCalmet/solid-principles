namespace CSharp.src.example2.ocp
{
    public class InventarioBebidas : BaseInventario
    {
        public InventarioBebidas(Producto producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
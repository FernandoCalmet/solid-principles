namespace CSharp.src.example2.ocp
{
    public class InventarioAlimentos : BaseInventario
    {
        public InventarioAlimentos(Producto producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
namespace CSharp.src.example2.ocp
{
    public abstract class BaseInventario
    {
        protected Producto producto;

        public BaseInventario(Producto producto)
        {
            this.producto = producto;
        }

        public Producto Producto { get => producto; set => producto = value; }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}

namespace Tienda_Guitarras
{
    public abstract class Guitarra
    {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string TipoCuerda { get; protected set; }
        public int CantidadInventario { get; protected set; }

        public Guitarra(string marca, string modelo, string tipoCuerda, int cantidadInventario)
        {
            Marca = marca;
            Modelo = modelo;
            TipoCuerda = tipoCuerda;
            CantidadInventario = cantidadInventario;
        }

        public string ObtenerMarca()
        {
            return Marca;
        }

        public string ObtenerModelo()
        {
            return Modelo;
        }

        public string ObtenerTipoCuerda()
        {
            return TipoCuerda;
        }

        public int ObtenerCantidadInventario()
        {
            return CantidadInventario;
        }
    }


}

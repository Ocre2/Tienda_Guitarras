using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tienda_Guitarras
{
    public class GuitarraElectrica : Guitarra
    {
        private int numeroCuerdas;

        public GuitarraElectrica(string marca, string modelo, string tipoCuerda, int cantidadInventario, int numeroCuerdas)
            : base(marca, modelo, tipoCuerda, cantidadInventario)
        {
            this.numeroCuerdas = numeroCuerdas;
        }

        public int ObtenerNumeroCuerdas()
        {
            return numeroCuerdas;
        }

        public void VenderGuitarra()
        {
            Console.WriteLine("Se ha vendido la guitarra eléctrica: " + Marca + " " + Modelo);
            CantidadInventario--;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tienda_Guitarras
{
    public class GuitarraAcustica : Guitarra
    {
        private string FormaCuerpo;

        public GuitarraAcustica(string marca, string modelo, string tipoCuerda, int cantidadInventario, string formaCuerpo)
            : base(marca, modelo, tipoCuerda, cantidadInventario)
        {
            FormaCuerpo = formaCuerpo;
        }

        public string ObtenerFormaCuerpo()
        {
            return FormaCuerpo;
        }

        public void RealizarMantenimiento()
        {
            Console.WriteLine("Se ha realizado el mantenimiento de la guitarra acústica: " + Marca + " " + Modelo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Guitarras
{
    public class EstadisticasGuitarras
    {
        public List<Guitarra> listaGuitarras;

        public EstadisticasGuitarras()
        {
            listaGuitarras = new List<Guitarra>();
        }

        public void AgregarGuitarra(Guitarra guitarra)
        {
            listaGuitarras.Add(guitarra);
        }

        public int ObtenerCantidadTotalGuitarras()
        {
            return listaGuitarras.Count;
        }

        public int ObtenerCantidadGuitarrasAcusticas()
        {
            int count = 0;
            foreach (Guitarra guitarra in listaGuitarras)
            {
                if (guitarra is GuitarraAcustica)
                {
                    count++;
                }
            }
            return count;
        }

        public int ObtenerCantidadGuitarrasElectricas()
        {
            int count = 0;
            foreach (Guitarra guitarra in listaGuitarras)
            {
                if (guitarra is GuitarraElectrica)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

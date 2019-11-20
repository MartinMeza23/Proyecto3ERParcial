using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3ERParcial
{
    class Pelicula : Programa
    {
        public Pelicula(string titulo, int año)
        {
            this.Titulo = titulo;
            this.Año = año;
        }
    }
}

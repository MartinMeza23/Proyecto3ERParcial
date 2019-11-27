using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3ERParcial
{
    class Pelicula : DatosPeli_Ser
    {
        public Pelicula(string titulo, int año, string genero, string director, string sinopsis, int rating)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Sinopsis = sinopsis;
            this.Rating = rating;
        }
        public override string ToString()
        {
            return this.Titulo + "   " + this.Año;
        }
    }
}

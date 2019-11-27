using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3ERParcial
{
    class Serie : DatosPeli_Ser
    {
        public Serie(string titulo, int año, string genero, int temporada, string productor, string descripcion, int rating)
        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporada = temporada;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Rating = rating;
        }
        public override string ToString()
        {
            return this.Titulo + "   " + this.Año;
        }
    }
}

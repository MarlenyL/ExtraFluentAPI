using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFluentApi.Models
{
    class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Duracion { get; set; }
        public string Clasificion { get; set; }
        public string Director { get; set; }

        //Para ejemplo one-one
        /*public int PeliculaId { get; set; }
        public AccesoPremier accesoPremier { get; set; }*/

        public IList<AccesoPremierB> AccesoPremierBs { get; set; }
        public ICollection<AccesoPremier> AccesoPremiers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFluentApi.Models
{
    class AccesoPremierB
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}

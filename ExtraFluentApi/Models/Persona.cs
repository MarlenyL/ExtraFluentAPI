using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraFluentApi.Models
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }

        public IList<AccesoPremierB> AccesoPremierBs { get; set; }
        public ICollection<AccesoPremier> AccesoPremiers { get; set; }
    }
}

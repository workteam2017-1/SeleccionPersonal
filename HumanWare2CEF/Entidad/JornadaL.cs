using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class JornadaL
    {
        [Key]
        public string IdJornada { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<JornadaL> Jornadas { get; set; }
    }
}

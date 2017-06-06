using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Administrador
    {
        [Key]
        public string usuario1 { get; set; }
        public string contrasena { get; set; }
        public virtual ICollection<Administrador> Administradores { get; set; }
    }

    public class Evaluador
    {
        [Key]
        public string usuario2 { get; set; }
        public string contrasena { get; set; }
        public virtual ICollection<Evaluador> Evaluadores { get; set; }

    }
}

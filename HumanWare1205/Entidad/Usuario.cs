using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entidad
{
    public class Usuario
    {
        [Key]
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}

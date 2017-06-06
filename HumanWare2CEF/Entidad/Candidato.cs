using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Candidato
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int IDCandidato { get; set; }
        public string nombreApellidos { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public int retribucionMin { get; set; }
        public bool jornada { get; set; }
        public string titulacion { get; set; }
        public int ItemEquipo { get; set; }
        public int ItemDecisiones { get; set; }
        public int ItemIngles { get; set; }
        public int ItemComunicacion { get; set; }
        public int ItemInformes { get; set; }
        public int ItemPuntualidad { get; set; }
        public int ItemInformacion { get; set; }
        public int ItemDatos { get; set; }
        public int ItemSoftware { get; set; }
        public int ItemVender { get; set; }


        public virtual ICollection<Candidato> Candidatos { get; set; }

    }
}

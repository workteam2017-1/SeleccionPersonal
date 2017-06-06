using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class OfertaVacante
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int IDVacante { get; set; }
        public string empresa { get; set; }
        public int telefonoEmpresa{ get; set; }
        public string nombrePuesto { get; set; }
        public string descripcion { get; set; }
        public int rangoMin { get; set; }
        public int rangoMax { get; set; }
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

        public virtual ICollection<OfertaVacante> Vacantes { get; set; }

    }
}

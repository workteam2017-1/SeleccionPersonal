using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class CandidatoxOfertaVacante
    {
        [Key]
        [Column(Order = 1)]
        public int IDCandidato { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IDVacante { get; set; }
        public virtual ICollection<CandidatoxOfertaVacante> CandidatoxOferta { get; set; }

    }
}

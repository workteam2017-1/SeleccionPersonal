using System.Data.Entity;
using Entidad;

namespace AccesoDatos
{
    public class HumanWareContext : DbContext
    {
        public HumanWareContext()
        : base("name=HumanWareConnection")
        { }

        public DbSet<OfertaVacante> Oferta { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CandidatoxOfertaVacante> CandidatoxOfertaVacante { get; set; }
    }
}

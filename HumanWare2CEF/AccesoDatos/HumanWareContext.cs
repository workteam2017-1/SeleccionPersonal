using System.Data.Entity;
using Entidad;

namespace AccesoDatos
{
    public class HumanWareContext : DbContext
    {
        public HumanWareContext()
        : base("name=HumanWareConnection")
        {
            Database.SetInitializer(new HumanWareInitializer());
        }

        public DbSet<OfertaVacante> Oferta { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Evaluador> Evaluadores { get; set; }
        public DbSet<JornadaL> Jornada{ get; set; }
        public DbSet<CandidatoxOfertaVacante> CandidatoxOfertaVacante { get; set; }
    }
}

using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class HumanWareInitializer : DropCreateDatabaseIfModelChanges<HumanWareContext>
    {
        protected override void Seed(HumanWareContext context)
        {
            Administrador newAdmin = new Administrador();
            newAdmin.usuario1 = "admin";
            newAdmin.contrasena = "123";
            context.Administradores.Add(newAdmin);
            Evaluador newEval = new Evaluador();
            newEval.usuario2 = "eval";
            newEval.contrasena = "123";
            context.Evaluadores.Add(newEval);

            //context.Jornada.Add(new JornadaL() { IdJornada = 1, Nombre = "Completa" });
            //context.Jornada.Add(new JornadaL() { IdJornada = 2, Nombre = "Parcial" });
            //context.Jornada.Add(new JornadaL() { IdJornada = 3, Nombre = "Ambas" });

            base.Seed(context);
        }
    }
}

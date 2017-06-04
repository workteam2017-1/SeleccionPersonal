using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ControlHumanWare
    {
        public void IngresarCandidato(Candidato candidato)
        {
            AccesoDatosHumanWare.IngresarCandidato(candidato);
        }

        public void EliminarCandidato(int IDCandidato)
        {
            AccesoDatosHumanWare.EliminarCandidato(IDCandidato);
        }

        public void IngresarVacante(OfertaVacante vacante)
        {
            System.Diagnostics.Debug.WriteLine("IngresarVacante");
            AccesoDatosHumanWare.IngresarVacante(vacante);
        }

        public void SetVacanteActual(int IDVacante)
        {
            System.Diagnostics.Debug.WriteLine("IngresarVacante");
            AccesoDatosHumanWare.SetVacanteActual(IDVacante);
        }
    }
}

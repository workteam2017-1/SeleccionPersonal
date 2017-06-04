using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public static class AccesoDatosHumanWare
    {
        public static Candidato candidatoActual;
        public static OfertaVacante vacanteActual;

        public static void IngresarCandidato(Candidato candidato)
        {
            HumanWareContext context = new HumanWareContext();
            Candidato candidatoBusqueda = context.Candidatos.
                FirstOrDefault(p => p.IDCandidato.Equals(candidato.IDCandidato));

            if (candidatoBusqueda == null)
            {
                context.Candidatos.Add(candidato);

                //context.SaveChanges();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Candidato ya existe");
            }

            CandidatoxOfertaVacante candidatoxOferta = context.CandidatoxOfertaVacante.
              FirstOrDefault(p => p.IDCandidato.Equals(candidato.IDCandidato) && p.IDVacante.Equals(vacanteActual.IDVacante));

            if (candidatoxOferta == null)
            {
                candidatoxOferta = new CandidatoxOfertaVacante();
                candidatoxOferta.IDVacante = vacanteActual.IDVacante;
                candidatoxOferta.IDCandidato = candidato.IDCandidato;
                context.CandidatoxOfertaVacante.Add(candidatoxOferta);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Candidato ya se registró con anterioridad a esta oferta");
            }


            context.SaveChanges();
        }

        public static void EliminarCandidato(int IDCandidato)
        {
            HumanWareContext context = new HumanWareContext();
            Candidato candidato = context.Candidatos.
                FirstOrDefault(p => p.IDCandidato.Equals(IDCandidato));

            if (candidato != null)
            {
                context.Candidatos.Remove(candidato);
                context.SaveChanges();
            }
        }

        public static void SetCandidatoActual(int IDCandidato)
        {
            HumanWareContext context = new HumanWareContext();
            candidatoActual = context.Candidatos.
                FirstOrDefault(p => p.IDCandidato.Equals(IDCandidato));
        }

        public static void IngresarVacante(OfertaVacante vacante)
        {
            System.Diagnostics.Debug.WriteLine("Vacante");

            HumanWareContext context = new HumanWareContext();
            OfertaVacante vacanteBusqueda = context.Oferta.
                FirstOrDefault(p => p.IDVacante.Equals(vacante.IDVacante));


            if (vacanteBusqueda == null)
            {
                System.Diagnostics.Debug.WriteLine("Null");
                context.Oferta.Add(vacante);
                //context.SaveChanges();
            }
            else
            {
                vacanteBusqueda.IDVacante = vacante.IDVacante;
                vacanteBusqueda.empresa = vacante.empresa;
                vacanteBusqueda.telefonoEmpresa = vacante.telefonoEmpresa;
                vacanteBusqueda.nombrePuesto = vacante.nombrePuesto;
                vacanteBusqueda.descripcion = vacante.descripcion;
                vacanteBusqueda.rangoMin = vacante.rangoMin;
                vacanteBusqueda.rangoMax= vacante.rangoMax;
                vacanteBusqueda.jornada = vacante.jornada;
                vacanteBusqueda.titulacion = vacante.titulacion;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;
                vacanteBusqueda.ItemDecisiones = vacante.ItemDecisiones;
                vacanteBusqueda.ItemIngles = vacante.ItemIngles;
                vacanteBusqueda.ItemComunicacion = vacante.ItemComunicacion;
                vacanteBusqueda.ItemInformes = vacante.ItemInformes;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;
                vacanteBusqueda.ItemEquipo = vacante.ItemEquipo;

            }
            context.SaveChanges();
        }

        public static void SetVacanteActual(int IDVacante)
        {
            HumanWareContext context = new HumanWareContext();
            vacanteActual = context.Oferta.
                 FirstOrDefault(p => p.IDVacante.Equals(IDVacante));

            System.Diagnostics.Debug.WriteLine(vacanteActual.empresa + " -.-.-. ");
        }

    }
}

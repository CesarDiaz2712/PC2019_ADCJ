using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    public class InformacionLaboral
    {
        private Int32 idInformacionLaboral; 
        private string trabajoLigadoFormacion;
        private string cargoDesempenado;
        private string tipoContratacion;
        private string tiempoTranscurridoPrimerEmpleo;
        private string promedioIngresoMensual;
        private string razonNoEncontrartrabajo;
        private string importanciaExperiencia;
        private string tipoOrganismo;
        private string conocimientosTeoricos;
        private string saberesHeuristicos;
        private string experienciaEducativaCursada;
        private string saberesTeoricosRespuesta1;
        private string saberesTeoricosRespuesta2;
        private string saberesTeoricosRespuesta3;
        private string saberesTeoricosRespuesta4;
        private string saberesTeoricosRespuesta5;
        private string saberesTeoricosRespuesta6;
        private string saberesTeoricosRespuesta7;
        private string saberesTeoricosRespuesta8;
        private string saberesTeoricosRespuesta9;
        private string saberesTeoricosRespuesta10;
        private string saberesHeuristicosRespuesta1;
        private string saberesHeuristicosRespuesta2;
        private string saberesHeuristicosRespuesta3;
        private string saberesHeuristicosRespuesta4;
        private string saberesHeuristicosRespuesta5;
        private string saberesHeuristicosRespuesta6;
        private string saberesHeuristicosRespuesta7;
        private string saberesAxiologicosRespuesta1;
        private string saberesAxiologicosRespuesta2;
        private string saberesAxiologicosRespuesta3;
        private string saberesAxiologicosRespuesta4;
        private string saberesAxiologicosRespuesta5;
        private string saberesAxiologicosRespuesta6;
        private string saberesAxiologicosRespuesta7;
        private string saberesAxiologicosRespuesta8;
        private string saberesAxiologicosRespuesta9;
        private string saberesAxiologicosRespuesta10;
        private string saberesAxiologicosRespuesta11;
        private string saberesAxiologicosRespuesta12;
        private string saberesAxiologicosRespuesta13;
        private string saberesAxiologicosRespuesta14;
        private string saberesAxiologicosRespuesta15;
        private string saberesAxiologicosRespuesta16;
        private string saberesAxiologicosRespuesta17;
        private string saberesAxiologicosRespuesta18;
        private string saberesAxiologicosRespuesta19;
        private string funcionesRealizadasRespuesta1;
        private string funcionesRealizadasRespuesta2;
        private string funcionesRealizadasRespuesta3;
        private string funcionesRealizadasRespuesta4;
        private string funcionesRealizadasRespuesta5;
        private string funcionesRealizadasRespuesta6;
        private string funcionesDesempenadas;
        private string problematicasSolucionadas;
        private string propiaEmpresa;
        private string propiaEmpresaPorque;
        private string diferenciaConocimientoRespuesta1;
        private string diferenciaConocimientoRespuesta2;
        private string diferenciaConocimientoRespuesta3;
        private string diferenciaConocimientoRespuesta4;
        private string diferenciaConocimientoRespuesta5;
        private string diferenciaConocimientoRespuesta6;
        private string diferenciaConocimientoRespuesta7;
        private string conocimientosBasico1;
        private string conocimientosBasico2;
        private string conocimientosBasico3;
        private string conocimientosBasico4;
        private string conocimientosBasico5;
        private string conocimientosBasico6;
        private string conocimientosBasico7;
        private string conocimientosBasico8;
        private string formacionProfesional;
        private Int32 idEgresado;
        

        public override string ToString()
        {
            return String.Format("idInformacionLaboral: {0} ,  idEgresado: {1}", idInformacionLaboral, idEgresado);
        }
        public int IdInformacionLaboral { get => idInformacionLaboral; set => idInformacionLaboral = value; }
        public int IdEgresado { get => idEgresado; set => idEgresado = value; }
        public string CargoDesempenado { get => cargoDesempenado; set => cargoDesempenado = value; }
        public string TipoContratacion { get => tipoContratacion; set => tipoContratacion = value; }
        public string TiempoTranscurridoPrimerEmpleo { get => tiempoTranscurridoPrimerEmpleo; set => tiempoTranscurridoPrimerEmpleo = value; }
        public string PromedioIngresoMensual { get => promedioIngresoMensual; set => promedioIngresoMensual = value; }
        public string RazonNoEncontrartrabajo { get => razonNoEncontrartrabajo; set => razonNoEncontrartrabajo = value; }
        public string ImportanciaExperiencia { get => importanciaExperiencia; set => importanciaExperiencia = value; }
        public string TipoOrganismo { get => tipoOrganismo; set => tipoOrganismo = value; }
        public string ConocimientosTeoricos { get => conocimientosTeoricos; set => conocimientosTeoricos = value; }
        public string SaberesHeuristicos { get => saberesHeuristicos; set => saberesHeuristicos = value; }
        public string ExperienciaEducativaCursada { get => experienciaEducativaCursada; set => experienciaEducativaCursada = value; }
        public string SaberesTeoricosRespuesta1 { get => saberesTeoricosRespuesta1; set => saberesTeoricosRespuesta1 = value; }
        public string SaberesTeoricosRespuesta2 { get => saberesTeoricosRespuesta2; set => saberesTeoricosRespuesta2 = value; }
        public string SaberesTeoricosRespuesta3 { get => saberesTeoricosRespuesta3; set => saberesTeoricosRespuesta3 = value; }
        public string SaberesTeoricosRespuesta4 { get => saberesTeoricosRespuesta4; set => saberesTeoricosRespuesta4 = value; }
        public string SaberesTeoricosRespuesta5 { get => saberesTeoricosRespuesta5; set => saberesTeoricosRespuesta5 = value; }
        public string SaberesTeoricosRespuesta6 { get => saberesTeoricosRespuesta6; set => saberesTeoricosRespuesta6 = value; }
        public string SaberesTeoricosRespuesta7 { get => saberesTeoricosRespuesta7; set => saberesTeoricosRespuesta7 = value; }
        public string SaberesTeoricosRespuesta8 { get => saberesTeoricosRespuesta8; set => saberesTeoricosRespuesta8 = value; }
        public string SaberesTeoricosRespuesta9 { get => saberesTeoricosRespuesta9; set => saberesTeoricosRespuesta9 = value; }
        public string SaberesTeoricosRespuesta10 { get => saberesTeoricosRespuesta10; set => saberesTeoricosRespuesta10 = value; }
        public string SaberesHeuristicosRespuesta1 { get => saberesHeuristicosRespuesta1; set => saberesHeuristicosRespuesta1 = value; }
        public string SaberesHeuristicosRespuesta2 { get => saberesHeuristicosRespuesta2; set => saberesHeuristicosRespuesta2 = value; }
        public string SaberesHeuristicosRespuesta3 { get => saberesHeuristicosRespuesta3; set => saberesHeuristicosRespuesta3 = value; }
        public string SaberesHeuristicosRespuesta4 { get => saberesHeuristicosRespuesta4; set => saberesHeuristicosRespuesta4 = value; }
        public string SaberesHeuristicosRespuesta5 { get => saberesHeuristicosRespuesta5; set => saberesHeuristicosRespuesta5 = value; }
        public string SaberesHeuristicosRespuesta6 { get => saberesHeuristicosRespuesta6; set => saberesHeuristicosRespuesta6 = value; }
        public string SaberesHeuristicosRespuesta7 { get => saberesHeuristicosRespuesta7; set => saberesHeuristicosRespuesta7 = value; }
        public string SaberesAxiologicosRespuesta1 { get => saberesAxiologicosRespuesta1; set => saberesAxiologicosRespuesta1 = value; }
        public string SaberesAxiologicosRespuesta2 { get => saberesAxiologicosRespuesta2; set => saberesAxiologicosRespuesta2 = value; }
        public string SaberesAxiologicosRespuesta3 { get => saberesAxiologicosRespuesta3; set => saberesAxiologicosRespuesta3 = value; }
        public string SaberesAxiologicosRespuesta4 { get => saberesAxiologicosRespuesta4; set => saberesAxiologicosRespuesta4 = value; }
        public string SaberesAxiologicosRespuesta5 { get => saberesAxiologicosRespuesta5; set => saberesAxiologicosRespuesta5 = value; }
        public string SaberesAxiologicosRespuesta6 { get => saberesAxiologicosRespuesta6; set => saberesAxiologicosRespuesta6 = value; }
        public string SaberesAxiologicosRespuesta7 { get => saberesAxiologicosRespuesta7; set => saberesAxiologicosRespuesta7 = value; }
        public string SaberesAxiologicosRespuesta8 { get => saberesAxiologicosRespuesta8; set => saberesAxiologicosRespuesta8 = value; }
        public string SaberesAxiologicosRespuesta9 { get => saberesAxiologicosRespuesta9; set => saberesAxiologicosRespuesta9 = value; }
        public string SaberesAxiologicosRespuesta10 { get => saberesAxiologicosRespuesta10; set => saberesAxiologicosRespuesta10 = value; }
        public string SaberesAxiologicosRespuesta11 { get => saberesAxiologicosRespuesta11; set => saberesAxiologicosRespuesta11 = value; }
        public string SaberesAxiologicosRespuesta12 { get => saberesAxiologicosRespuesta12; set => saberesAxiologicosRespuesta12 = value; }
        public string SaberesAxiologicosRespuesta13 { get => saberesAxiologicosRespuesta13; set => saberesAxiologicosRespuesta13 = value; }
        public string SaberesAxiologicosRespuesta14 { get => saberesAxiologicosRespuesta14; set => saberesAxiologicosRespuesta14 = value; }
        public string SaberesAxiologicosRespuesta15 { get => saberesAxiologicosRespuesta15; set => saberesAxiologicosRespuesta15 = value; }
        public string SaberesAxiologicosRespuesta16 { get => saberesAxiologicosRespuesta16; set => saberesAxiologicosRespuesta16 = value; }
        public string SaberesAxiologicosRespuesta17 { get => saberesAxiologicosRespuesta17; set => saberesAxiologicosRespuesta17 = value; }
        public string SaberesAxiologicosRespuesta18 { get => saberesAxiologicosRespuesta18; set => saberesAxiologicosRespuesta18 = value; }
        public string SaberesAxiologicosRespuesta19 { get => saberesAxiologicosRespuesta19; set => saberesAxiologicosRespuesta19 = value; }
        public string FuncionesRealizadasRespuesta1 { get => funcionesRealizadasRespuesta1; set => funcionesRealizadasRespuesta1 = value; }
        public string FuncionesRealizadasRespuesta2 { get => funcionesRealizadasRespuesta2; set => funcionesRealizadasRespuesta2 = value; }
        public string FuncionesRealizadasRespuesta3 { get => funcionesRealizadasRespuesta3; set => funcionesRealizadasRespuesta3 = value; }
        public string FuncionesRealizadasRespuesta4 { get => funcionesRealizadasRespuesta4; set => funcionesRealizadasRespuesta4 = value; }
        public string FuncionesRealizadasRespuesta5 { get => funcionesRealizadasRespuesta5; set => funcionesRealizadasRespuesta5 = value; }
        public string FuncionesRealizadasRespuesta6 { get => funcionesRealizadasRespuesta6; set => funcionesRealizadasRespuesta6 = value; }
        public string FuncionesDesempenadas { get => funcionesDesempenadas; set => funcionesDesempenadas = value; }
        public string ProblematicasSolucionadas { get => problematicasSolucionadas; set => problematicasSolucionadas = value; }
        public string PropiaEmpresa { get => propiaEmpresa; set => propiaEmpresa = value; }
        public string PropiaEmpresaPorque { get => propiaEmpresaPorque; set => propiaEmpresaPorque = value; }
        public string DiferenciaConocimientoRespuesta1 { get => diferenciaConocimientoRespuesta1; set => diferenciaConocimientoRespuesta1 = value; }
        public string DiferenciaConocimientoRespuesta2 { get => diferenciaConocimientoRespuesta2; set => diferenciaConocimientoRespuesta2 = value; }
        public string DiferenciaConocimientoRespuesta3 { get => diferenciaConocimientoRespuesta3; set => diferenciaConocimientoRespuesta3 = value; }
        public string DiferenciaConocimientoRespuesta4 { get => diferenciaConocimientoRespuesta4; set => diferenciaConocimientoRespuesta4 = value; }
        public string DiferenciaConocimientoRespuesta5 { get => diferenciaConocimientoRespuesta5; set => diferenciaConocimientoRespuesta5 = value; }
        public string DiferenciaConocimientoRespuesta6 { get => diferenciaConocimientoRespuesta6; set => diferenciaConocimientoRespuesta6 = value; }
        public string DiferenciaConocimientoRespuesta7 { get => diferenciaConocimientoRespuesta7; set => diferenciaConocimientoRespuesta7 = value; }
        public string FormacionProfesional { get => formacionProfesional; set => formacionProfesional = value; }
        public string TrabajoLigadoFormacion { get => trabajoLigadoFormacion; set => trabajoLigadoFormacion = value; }
        public string ConocimientosBasico1 { get => conocimientosBasico1; set => conocimientosBasico1 = value; }
        public string ConocimientosBasico2 { get => conocimientosBasico2; set => conocimientosBasico2 = value; }
        public string ConocimientosBasico3 { get => conocimientosBasico3; set => conocimientosBasico3 = value; }
        public string ConocimientosBasico4 { get => conocimientosBasico4; set => conocimientosBasico4 = value; }
        public string ConocimientosBasico5 { get => conocimientosBasico5; set => conocimientosBasico5 = value; }
        public string ConocimientosBasico6 { get => conocimientosBasico6; set => conocimientosBasico6 = value; }
        public string ConocimientosBasico7 { get => conocimientosBasico7; set => conocimientosBasico7 = value; }
        public string ConocimientosBasico8 { get => conocimientosBasico8; set => conocimientosBasico8 = value; }
    }
}

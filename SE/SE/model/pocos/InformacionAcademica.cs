using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    public class InformacionAcademica
    {
        private Int32 idInformacionAcademica;
        private String respuesta;
        private Int32 idEgresado;
   

        public override string ToString()
        {
            return String.Format("idInformacionAcademica: {0} , respuesta:{1}, idEgresado{2}"  , 
                   idInformacionAcademica, respuesta, idEgresado);
        }
        public int IdInformacionAcademica { get => idInformacionAcademica; set => idInformacionAcademica = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public int IdEgresado { get => idEgresado; set => idEgresado = value; }
        

    }
}

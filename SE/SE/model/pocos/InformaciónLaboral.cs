using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    class InformaciónLaboral
    {
        private Int32 idInformacionLaboral;
        private String respuesta;
        private Int32 idEgresado;
        private Int32 idRespuestaLaboral;

        public override string ToString()
        {
            return String.Format("idInformacionLaboral: {0} , respuesta:{1},  idRespuestaLaboral:{2}"
                   , idInformacionLaboral, respuesta, idRespuestaLaboral);
        }
        public int IdInformacionAcademica { get => idInformacionLaboral; set => idInformacionLaboral = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        private int IdRespuestaLaboral { get => idRespuestaLaboral; set => idRespuestaLaboral = value; }
    }
}

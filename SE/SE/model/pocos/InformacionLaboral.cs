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
        private String respuesta;
        private Int32 idEgresado;
        

        public override string ToString()
        {
            return String.Format("idInformacionLaboral: {0} , respuesta:{1},  idEgresado:{2}"
                   , idInformacionLaboral, respuesta, idEgresado);
        }
        public int IdInformacionLaboral { get => idInformacionLaboral; set => idInformacionLaboral = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public int IdEgresado { get => idEgresado; set => idEgresado = value; }
    }
}

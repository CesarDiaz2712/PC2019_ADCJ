using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoEgresados.Classes
{
    class Egresado
    {
        private string matricula;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string nombre;
        private string numeroTelefonico;
        private string correoElectronico;

        public Egresado()
        {

        }
        public Egresado(string matricula, string apellidoPaterno, string apellidoMaterno, string nombre)
        {
            this.matricula = matricula;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.nombre = nombre;
        }

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
            set
            {
                apellidoPaterno = value;
            }
        }

        public string ApellidoMaterno
        {
            get
            {
                return apellidoMaterno;
            }
            set
            {
                apellidoMaterno = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string NumeroTelefonico
        {
            get
            {
                return numeroTelefonico;
            }
            set
            {
                numeroTelefonico = value;
            }
        }

        public string CorreoElectronico
        {
            get
            {
                return correoElectronico;
            }
            set
            {
                correoElectronico = value;
            }
        }
    }
}

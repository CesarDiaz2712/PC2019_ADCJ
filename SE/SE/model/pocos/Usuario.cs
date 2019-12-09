using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    public class Usuario
    {
        private Int32 idUsuario;
        private String nombreUsuario;
        private String contrasena;

        public override string ToString()
        {
            return String.Format("idUsuario: {0}, nombreUsuario: {1}, contrasena: {2}", idUsuario,nombreUsuario,contrasena);
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}

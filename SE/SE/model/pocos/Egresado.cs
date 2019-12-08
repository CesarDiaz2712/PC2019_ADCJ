using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    class Egresado
    {
        private Int32 idEgresado;
        private String matricula;
        private String apellidos;
        private String nombre;
        private String correElectronico;
        private String telefono;

        public override string ToString()
        {
            return String.Format("idEgresado: {0}, matricula: {1}, apellidos: {2}, nombre: {3}, " +
                "correoElectronico: {4}, telefono: {5}", idEgresado, matricula, apellidos, nombre, correElectronico, telefono);
        }

        public int IdEgresado { get => idEgresado; set => idEgresado = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoElectronico { get => correElectronico; set => correElectronico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}

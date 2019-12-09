using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.model.pocos
{
    class FichaPreEgreso
    {
        private Int32 idFichaPreEgreso;
        private String matricula;
        private String apellidos;
        private String nombre;
        private String fechaNacimiento;
        private String sexo;
        private String nacionalidad;
        private String direccion;
        private String telefono;
        private String email;
        private Int32 idEgresado;

        public override string ToString()
        {
            return String.Format("idFichaPreEgreso: {0}, matricula: {1}, apellidos: {2}, nombre: {3}, fechaNacimiento: {4}" +
                "sexo: {5}, nacionalidad: {6}, direccion: {7}, telefono: {8}, email: {9}", idFichaPreEgreso, matricula, apellidos, nombre, fechaNacimiento, sexo, nacionalidad, direccion, telefono, email);
        }

        public int IdFichaPreEgreso { get => idFichaPreEgreso; set => idFichaPreEgreso = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public String FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public Int32 IdEgresado { get => idEgresado; set => idEgresado = value; }

    }
}

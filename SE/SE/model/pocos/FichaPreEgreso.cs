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
        private DateTime fechaNacimiento;
        private String sexo;
        private String nacionalidad;
        private String telefono;
        private String email;
        private String calle;
        private String colonia;
        private String numeroCasa;
        private String ciudad;
        private String estado;
        private String codigoPostal;
        private Int32 idEgresado;

        public override string ToString()
        {
            return String.Format("idFichaPreEgreso: {0}, fechaNacimiento: {1}, sexo: {2}, nacionalidad: {3}, + 
                "telefono: {4}, email: {5}, calle: {6}, numeroCasa: {7}, colonia: {8}, ciudad: {9}, estado: {10}, codigoPostal: {11}, idEgresado: {12}", idFichaPreEgreso, fechaNacimiento, sexo, nacionalidad, direccion, telefono, email +
                calle, numeroCasa, colonia, ciudad, estado, codigoPostal, idEgresado);
        }

        public int IdFichaPreEgreso { get => idFichaPreEgreso; set => idFichaPreEgreso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public String Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public Int32 IdEgresado { get => idEgresado; set => idEgresado = value; }

    }
}

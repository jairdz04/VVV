using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Personas
    {
        #region "Atributos"
        private long ID;
        private int CC;
        private string Nombre;
        private string Pais;
        private string Ciudad;
        private string Direccion;
        private string Email;
        private int Telefono;
        
        #endregion

        #region "Propiedades"
        public long Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Cc
        {
            get { return CC; }
            set { CC = value; }
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string pais
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string ciudad
        {
            get { return Ciudad; }
            set { Ciudad = value; }
        }

        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }


        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public int telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
       


        #endregion

        #region "contructores"
         public Personas() {
            this.ID= 000;
             this.CC=0;
            this.nombre = "";
             this.Pais="";
             this.Ciudad = "";
            this.Direccion = "";
            this.Email="";
             this.Telefono= 0;
            
            
           
        }

        public Personas(long ID,int CC, string Nombre, string Pais, string Ciudad, string Direccion, string Email, int Telefono) {

            this.ID = ID;
            this.CC = CC;
            this.Nombre = Nombre;
            this.Pais = Pais;
            this.Ciudad = Ciudad;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
        }


#endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "Codigo: " + this.ID +
                    "\nCedula: " + this.CC +
                    "\nDNombre: " + this.Nombre +
                    "\nPais: " + this.Pais +
                    "\nCiudad: " + this.Ciudad +
                    "\nDireccion: " + this.Direccion +
                    "\nPEmail: " + this.Email +
                    "\nTelefono: " + this.Telefono ;

        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;

            if ((this.ID == o.ID) &&
                (this.CC == o.CC) &&
                (this.Nombre == o.Nombre) &&
                (this.Ciudad == o.Ciudad) &&
                (this.Pais == o.Pais) &&
                (this.Direccion == o.Direccion) &&
                (this.Email == o.Email) &&
                (this.Telefono == o.Telefono))

                result = true;

            return result;
        }

        #endregion

    }
}
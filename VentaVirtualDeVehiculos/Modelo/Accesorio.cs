using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Accesorio
    {

        public string ID_Accesorio { get; set; }
        public string Nombre_Accesorio { get; set; }

        public Terrestres Terrestres
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public Accesorio()
        {
            ID_Accesorio = "A1";
            Nombre_Accesorio = "Accesorio";

        }

        public Accesorio(string ID_Accesorio, string Nombre_Accesorio)
        {
            this.ID_Accesorio = ID_Accesorio;
            this.Nombre_Accesorio = Nombre_Accesorio;

        }

        public override string ToString()
        {
            return "{ " + ID_Accesorio + " , " + Nombre_Accesorio + "}";
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}
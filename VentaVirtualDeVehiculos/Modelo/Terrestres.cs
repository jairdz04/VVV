using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Terrestres: Vehiculos
    {

        #region "Atributos"
        private int NumeroLlantas;
        private int NumeroEjes;
        protected List<Accesorio> nuevoAccesorio = new List<Accesorio>();
        #endregion

        #region "Propiedades"
        public int numeroLlantas
        {
            get { return NumeroLlantas; }
            set { NumeroLlantas = value; }
        }
        public int numeroEjes
        {
            get { return NumeroEjes; }
            set { NumeroEjes = value; }
        }
        #endregion

        #region "Constructores"
        public Terrestres()
            : base()
        {
            NumeroLlantas = 0;
            NumeroEjes = 0;
        }

        public Terrestres(long ID_Vehiculo,int Placa,int Modelo, double Precio,string Marca,string Color,string Combustible,int Capacidad, int Num_Motores, int NumeroLlantas, int NumeroEjes)
            : base(ID_Vehiculo,Placa,Modelo,Precio,Marca,Color,Combustible,Capacidad,Num_Motores)
        {
            this.NumeroLlantas = NumeroLlantas;
            this.NumeroEjes = NumeroEjes;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                    "Numero de Llantas: " + this.numeroLlantas +
                    "\nModelo: " + this.NumeroEjes + '\n';
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Terrestres o = (Terrestres)obj;
            bool result = false;

            if ((base.Equals(o)) &&
                (this.numeroLlantas == o.numeroLlantas) &&
                (this.NumeroEjes == o.NumeroEjes))

                result = true;

            return result;
        }

        public override string AgregarAccesorios(Accesorio nuevasPiezas)
        {
            nuevoAccesorio.Add(nuevasPiezas);
            string result = "";

            foreach (Accesorio element in nuevoAccesorio)
                result += "\n" + element;

            return "\n[Acccesorios] = {" + result + "\n}";

        }
        #endregion

        public string agregar(string[] list)
        {
            string result = "";

            foreach (string s in list)
                result += "\n" + s;

            return "\n[Acciones] = {" + result + "}";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Fluviales: Vehiculos
    {
        #region "Atributos"

        private string Accion; // Flotante/Sumergible
        private double Profundidad;
        protected List<Accesorio> nuevoAccesorio = new List<Accesorio>();
        #endregion

        #region "Propiedades"
        public double profundidad
        {
            get { return Profundidad; }
            set { Profundidad = value; }
        }
        public string accion
        {
            get { return Accion; }
            set { Accion = value; }
        }
        #endregion

        #region "Constructores"
        public Fluviales()
            : base()
        {
            this.Accion = "Flotante/Sumergible";
            this.Profundidad = 0;
        }

        public Fluviales(long ID_Vehiculo,int Placa,int Modelo, double Precio,string Marca,string Color,string Combustible,int Capacidad, int Num_Motores, string Accion, int Profundidad)
            : base(ID_Vehiculo,Placa,Modelo,Precio,Marca,Color,Combustible,Capacidad,Num_Motores)
        {
            this.Profundidad=Profundidad;
            this.Accion=Accion;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                    "Accion: " + this.Accion +
                    "\nProfundidad: " + this.Profundidad + '\n';
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Fluviales o = (Fluviales)obj;
            bool result = false;

            if ((base.Equals(o)) &&
                (this.Accion == o.Accion) &&
                (this.Profundidad == o.Profundidad))

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


        public override string agregarElementos(Accesorio nuevasPiezas)
        {
            nuevoAccesorio.Add(nuevasPiezas);
            string result = "";

            foreach (Accesorio element in nuevoAccesorio)
                result += "\n" + element;

            return "\n[Acciones] \n{" + result + "\n}";

        }

    }
}
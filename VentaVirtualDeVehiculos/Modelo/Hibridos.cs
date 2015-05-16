using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Hibridos : Vehiculos
    {

        private int numeroLlantas;
        private int numeroEjes;
        private double Altitud_MAx;
        private string AccionH; // // Flotante/Sumergible
        private double ProfundidaM;
        protected List<Accesorio> nuevoAccesorio = new List<Accesorio>();

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
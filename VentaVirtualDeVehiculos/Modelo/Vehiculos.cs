﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaVirtualDeVehiculos.Modelo
{
    public class Vehiculos
    {

        #region "Atributos"
        private long ID_Vehiculo;
       private int Placa;
       private int Modelo;
       private double Precio;
       private string Marca;
       private string Color;
       private string Combustible;
       private int Capacidad;
       private int Num_Motores;

#endregion 

       #region "Propiedades"
       public long iD_Vehiculo
       {
           get { return ID_Vehiculo; }
           set { ID_Vehiculo = value; }
       }

       public int placa
       {
           get { return Placa; }
           set { Placa = value; }
       }

       public int modelo
       {
           get { return Modelo; }
           set { Modelo = value; }
       }

       public double precio
       {
           get { return Precio; }
           set {Precio = value; }
       }

       public string marca
       {
           get { return Marca; }
           set { Marca = value; }
       }

       public string color
       {
           get { return Color; }
           set { Color = value; }
       }


       public string combustible
       {
           get { return Combustible; }
           set { Combustible = value; }
       }

       public int capacidad
       {
           get { return Capacidad; }
           set { Capacidad = value; }
       }
       public int Num_motores
       {
           get { return Num_Motores; }
           set { Num_Motores = value; }
       }



       #endregion

       #region "Constructores"
       public Vehiculos() {
            this.ID_Vehiculo = 0;
            this.Placa= 000;
            this.Precio = 0.00;
            this.Marca = "";
            this.Color = "Blanco";
            this.combustible = "Gasolina";
            this.Capacidad = 0;
            this.Num_Motores = 0;
        }

        public Vehiculos(long ID_Vehiculo, int Placa, int Modelo, Double Precio, string Marca, string Color, string Combustible,int Capacidad,int Num_Motores) {

            this.ID_Vehiculo = ID_Vehiculo;
            this.Placa = Placa;
            this.Modelo = Modelo;
            this.Precio = Precio;
            this.Marca = Marca;
            this.Color = Color;
            this.Combustible = Combustible;
            this.Capacidad = Capacidad;
            this.Num_motores = Num_motores;



    }

        #endregion

   

    #region "Métodos SobreEscritos"
        public override string ToString()
        {
                return  "ID Vehiculo: " + this.ID_Vehiculo +
                        "\nPlaca: " + this.Placa +
                        "\nModelo: " + this.Modelo +
                        "\nPrecio: " + this.Precio +
                        "\nMarca: " + this.Marca +
                        "\nColor: " + this.Color +
                        "\nCombustible: " + this.Combustible +
                        "\nCapacidad: " + this.Capacidad +
                        "\nNumero de Motores: " + this.Num_Motores+'\n';
            }
        public override int GetHashCode()
        {
 	     return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Vehiculos o = (Vehiculos)obj;
            bool result = false;

            if ((this.ID_Vehiculo == o.ID_Vehiculo) &&
                (this.Placa == o.Placa)&&
                (this.Modelo == o.Modelo) &&
                (this.Precio == o.Precio) &&
                (this.Color == o.Color) &&
                (this.Marca == o.Marca) &&
                (this.combustible == o.combustible) &&
                (this.Capacidad == o.Capacidad) &&
               (this.Num_Motores == o.Num_Motores) )

                result = true;

            return result;
        }

        #endregion

        #region "Abstractos"
        public abstract string agregarElementos(Accesorio nuevasPiezas);
        #endregion
}
}
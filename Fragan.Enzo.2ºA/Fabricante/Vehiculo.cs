using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima = 0;

        public int VelocidadMaxima {
            get
            {
                int ret = 0;
                if(this.velocidadMaxima == 0)
                {
                    ret= this.velocidadMaxima;
                }
                return ret;
            }
        }

        public static explicit operator string(Vehiculo v)
        {
            return Vehiculo.mostrar(v);
        }

        private static string mostrar(Vehiculo v)
        {
            string respuesta = "";
            respuesta += "Modelo: " + v.modelo + "\nPrecio: " + v.precio.ToString()+"\nFabricante: "+(string)v.fabricante+"\nVelocidad Maxima: "+v.VelocidadMaxima;
            return respuesta;
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            bool respuesta = false;
            if(a.modelo==b.modelo && a.fabricante==b.fabricante)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Vehiculo a,Vehiculo b)
        {
            return !(a == b);
        }

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
            
        }

        public Vehiculo(float precio,string modelo,Fabricante fabri) : base()
        {
            this.modelo = modelo;
            this.precio = precio;
            this.fabricante = fabri;
            this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 280);
        }

        public Vehiculo(string marca,EPais pais,string modelo,float precio) : base()
        {
            this.modelo = modelo;
            this.precio = precio;
            this.fabricante = new Fabricante(marca,pais);
            this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 280);
        }
    }
}

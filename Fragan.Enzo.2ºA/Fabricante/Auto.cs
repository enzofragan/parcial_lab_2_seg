using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        public ETipo tipo;

        public Auto(string modelo,float precio,Fabricante fabri,ETipo tipo) : base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if((Auto)obj==this)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static explicit operator Single(Auto a)
        {
            Single respuesta = 0;
            respuesta =(Single) a.precio;
            return respuesta;
        }

        public static bool operator ==(Auto a,Auto b)
        {
            bool respuesta = false;
            if(a.tipo==b.tipo && (Vehiculo)a==(Vehiculo)b)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Auto a,Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return (string)this + this.tipo.ToString();
        }
    }
}

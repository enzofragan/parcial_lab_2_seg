using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public ECilindrada cilindrada;

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if ((Moto)obj == this)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static implicit operator Single(Moto m)
        {
            Single respuesta = 0;
            respuesta = (Single)m.precio;
            return respuesta;
        }

        public Moto(string marca,EPais pais,string modelo,float precio,ECilindrada cilindrada) : base(marca,pais,modelo,precio)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Moto a, Moto b)
        {
            bool respuesta = false;
            if (a.cilindrada == b.cilindrada && (Vehiculo)a == (Vehiculo)b)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return (string)this + this.cilindrada.ToString();
        }
    }
}

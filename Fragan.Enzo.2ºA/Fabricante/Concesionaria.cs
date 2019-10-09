using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public double PrecioDeAutos { get; }
        public double PrecioDeMotos { get; }
        public double PrecioTotal { get; }

        private Concesionaria()
        {

        }

        private Concesionaria(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public static implicit operator Concesionaria(int capacidad)
        {

        }

        public string Mostrar(Concesionaria c)
        {

        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {

        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool respuesta = false;
            
            return respuesta;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }
    }
}

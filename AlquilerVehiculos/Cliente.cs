using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Cliente
    {
        private String nif;
        private String nombre;

        public string Nif { get => nif; set => nif = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public  override String ToString()
        {
            return "Nif: " + nif + " Nombre: " + nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.modelo
{
    internal class Cliente
    {
        private String nif;
        private String nombre;

        public string Nif { get => nif; set => nif = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public  override String ToString()
        {
            return  nif + "\t" + nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Coche : Vehiculo
    {
        private int plazas;
        private int puertas;

        public Coche()
        {
            this.plazas = 5;
            
        }
        public int Plazas { get => plazas; set => plazas = value; }
        public int Puertas { get => puertas; set => puertas = value; }

        public override string ToString()
        {
            return base.ToString() + " plazas: " + plazas + " puertas: " + puertas;
        }
    }
}

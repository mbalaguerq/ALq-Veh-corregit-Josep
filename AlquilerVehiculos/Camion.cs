using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Camion : Vehiculo
    {
        private int kg;

        public int Kg { get => kg; set => kg = value; }

        public override string ToString()
        {
            return base.ToString() + " kg: " + kg;
        }
    }
}

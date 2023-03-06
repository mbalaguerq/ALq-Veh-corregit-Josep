using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Flota
    {
        private string nombreZona;
        private ArrayList vehiculos;

        public Flota()
        {
            vehiculos = new ArrayList();
        }
        public string NombreZona { get => nombreZona; set => nombreZona = value; }
        // public ArrayList Vehiculos { get => vehiculos;  }

        public void addVehiculos(Vehiculo veh)
        {
            vehiculos.Add(veh);
        }


        public bool removeVehiculo(string matricula)
        {
            foreach (Vehiculo veh in vehiculos)
            {
                if (veh.Matricula.Equals(matricula))
                {
                    vehiculos.Remove(veh);
                    return true;
                }
            }
            return false;
        }

        public Vehiculo getVehiculoByMatricula(string matricula) {

            foreach (Vehiculo veh in vehiculos)
            {
                if (veh.Matricula.Equals(matricula))
                {
                   return veh;
                }
            }
            return null;
        }

        public ArrayList getVehiculos()
        {
            return vehiculos;
        }

        






        //int i = 0;
        //foreach (Vehiculo veh in vehiculos)
        //{
        //    Console.WriteLine(((Vehiculo)vehiculos[i]).Model);
        //    i++;
        //    if (veh is Coche)
        //    {
        //      //  Console.WriteLine(veh.Matricula);
        //        //   vehiculos.Remove(veh);
        //    }


    }
}





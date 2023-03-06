using AlquilerVehiculosMVC.controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal class EliminarVehiculoView
    {

        VehiculoController vehiculoController;


        public EliminarVehiculoView(VehiculoController pVehiculoController)
        {
            // revibimos por parámetro el controlador qu utilizara la vista
            vehiculoController = pVehiculoController;
        }

        public void eliminarVehiculo()
        {
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();
            string datosVehiculo = vehiculoController.getDatosVehiculo(matricula);
            if (datosVehiculo == null)
            {
                Console.WriteLine("El vehiculo no existe");
            }
            else
            {

                Console.WriteLine("¿Seguro que quieres eliminar? (s/n)");
                string ok = Console.ReadLine();
                if (ok.ToUpper().Equals("S"))
                {
                    vehiculoController.eliminarVehiculo(matricula);
                }
            }
        }
    }
}

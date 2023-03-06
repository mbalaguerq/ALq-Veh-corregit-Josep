using AlquilerVehiculosMVC.modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.controlador
{
    internal class VehiculoController
    {
        Datos datos;
        public VehiculoController(Datos pDatos)
        {
            // no hacemos un new datos , sino que recibimos el objeto datos
            // porr parametro con sus List/arraylist llenos de datos
            datos = pDatos;
        }
        public void eliminarVehiculo(string matricula)
        {
            datos.eliminarVehiculo(matricula);
        }
        public string getDatosVehiculo(string matricula)
        {
            string datosVehiculo;
            datosVehiculo = datos.getDatosVehiculo(matricula);
            return datosVehiculo;   
        }
      
    }
}

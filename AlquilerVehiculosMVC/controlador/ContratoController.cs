using AlquilerVehiculosMVC.modelo;
using AlquilerVehiculosMVC.vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.controlador
{
    internal class ContratoController
    {
        Datos datos;
        public ContratoController(Datos pdatos)
        {
            datos = pdatos;
        }
        public String getVehiculobytipo(string matricula)
        {
            string vehiculo=datos.getDatosVehiculo(matricula);
            return vehiculo;
        }
        public void addContrato(Hashtable contratohash )
        {
            datos.addContrato(contratohash);
        }
        public List<string> listarContratos()
        {
            List<string> ret = new List<string>(); 
            ret = datos.listarContratos();

            return ret;
        }


    }
}

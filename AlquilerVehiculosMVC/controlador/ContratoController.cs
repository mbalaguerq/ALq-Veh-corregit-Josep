using AlquilerVehiculosMVC.modelo;
using AlquilerVehiculosMVC.vista;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}

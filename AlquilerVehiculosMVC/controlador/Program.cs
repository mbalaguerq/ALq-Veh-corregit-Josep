using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlquilerVehiculosMVC.vista;
using AlquilerVehiculosMVC.modelo;

namespace AlquilerVehiculosMVC.controlador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //View vista = new View();
            //Datos modelo = new Datos();
            //Controlador controlador = new Controlador(modelo, vista);
            //controlador.gestionMenu();

            Controlador controlador = new Controlador();
            controlador.gestionMenu();
        }
    }
}

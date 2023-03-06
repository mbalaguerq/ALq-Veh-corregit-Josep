using AlquilerVehiculosMVC.controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal class ContratoView
    {
        ContratoController contratoController;
        public ContratoView() { }
        public ContratoView(ContratoController pcontratoController)
        {
            contratoController = pcontratoController;
        }
    }
   
}

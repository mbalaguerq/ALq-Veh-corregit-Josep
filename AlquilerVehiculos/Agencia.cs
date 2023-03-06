using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Agencia
    {
        private string nombre;
        private Flota flota;
        private ArrayList listaContratos;

        public Agencia()
        {
            this.listaContratos = new ArrayList();
        }
        public void addContrato(ContratoAlquiler contrato)
        {
            listaContratos.Add(contrato);
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public Flota Flota { get => flota; set => flota = value; }
        public ArrayList ListaContratos { get => listaContratos; }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class VehiculosRent
    {
        private String nif;
        private String nombre;
        private ArrayList listaClientes;
        private ArrayList flotas;
        private ArrayList agencias;
        public VehiculosRent()
        {
            listaClientes = new ArrayList();
            flotas = new ArrayList();
            agencias = new ArrayList();
        }


        public string Nif { get => nif; set => nif = value; }

        public String getNif()
        {
            return nif;
        }
        public void setNif(string value)
        {
            nif = value;
        }

        public int addFlota(Flota flota)
        {
            return flotas.Add(flota);

        }

        public int addCliente(Cliente cliente)
        {
            return listaClientes.Add(cliente);

        }
        public int addAgencia(Agencia agencia)
        {
            return agencias.Add(agencia);

        }

        public Cliente getClienteByNif(string nif)
        {
            foreach(Cliente cliente in listaClientes)
            {
                if (cliente.Nif.Equals(nif)){
                    return cliente;
                }
            }
            return null;

        }
        public Agencia getAgenciaByNombre(string nombre)
        {
            foreach (Agencia agencia in Agencias)
            {
                if (agencia.Nombre.Equals(nombre))
                {
                    return agencia;
                }
            }
            return null;

        }


        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList ListaClientes { get => listaClientes; }
        public ArrayList Flotas { get => flotas;  }
        public ArrayList Agencias { get => agencias;}
    }
}

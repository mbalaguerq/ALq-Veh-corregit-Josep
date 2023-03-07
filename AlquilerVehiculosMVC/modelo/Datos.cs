using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.modelo
{
    internal class Datos
    {
        private List<Vehiculo> vehiculos;
        private List<Cliente> clientes;
        private List<Contrato> contrato;
        public Datos()
        {
            vehiculos = new List<Vehiculo>();
            clientes = new List<Cliente>();
            contrato = new List<Contrato>();
        }
        public void addCliente(Hashtable clienteHas)
        {
            Cliente cliente = new Cliente();
            cliente.Nif = (string)clienteHas["Nif"];
            cliente.Nombre = (string)clienteHas["Nombre"];
            clientes.Add(cliente);
        }
        public void addCoche(Hashtable vehiculoHash)
        {
            Coche coche = new Coche();
            coche.Matricula = (string)vehiculoHash["Matricula"];
            coche.Marca = (string)vehiculoHash["Marca"];
            coche.Model = (string)vehiculoHash["Model"];
            coche.Puertas = (int)vehiculoHash["Puertas"];
            coche.Plazas = (int)vehiculoHash["Plazas"];
            vehiculos.Add(coche);
        }
        public void addMoto(Hashtable vehiculoHash)
        {
            Moto moto = new Moto();
            moto.Matricula = (string)vehiculoHash["Matricula"];
            moto.Marca = (string)vehiculoHash["Marca"];
            moto.Model = (string)vehiculoHash["Model"];
            moto.Cc = (int)vehiculoHash["cc"];
            vehiculos.Add(moto);
        }
        public void addCamion(Hashtable vehiculoHash)
        {
            Camion camion = new Camion();
            camion.Matricula = (string)vehiculoHash["Matricula"];
            camion.Marca = (string)vehiculoHash["Marca"];
            camion.Model = (string)vehiculoHash["Model"];
            camion.Kg = (int)vehiculoHash["kg"];
            vehiculos.Add(camion);
        }
        public void addContrato(Hashtable contratosHash)
        {
            Contrato ocontrato = new Contrato();
            ocontrato.FechaInicio = (DateTime)contratosHash["Fecha Inicio"];
            ocontrato.FechaFin = (DateTime)contratosHash["Fecha Fin"];
            ocontrato.PrecioDia = (decimal)contratosHash["Precio"];
            ocontrato.Vehiculo = (Vehiculo)contratosHash["Vehículo"];
            ocontrato.Cliente = (Cliente)contratosHash["Cliente"];
            contrato.Add(ocontrato);
        }
        public void eliminarVehiculo(string matricula)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Matricula.Equals(matricula))
                {
                    vehiculos.Remove(vehiculo);
                    return;
                }
            }
        }
        public void eliminarCLiente(string nif)
        {
            foreach (Cliente cli in clientes)
            {
                if(cli.Nif.Equals(nif))
                {
                    clientes.Remove(cli);
                    return;
                }
            }
        }
        public string getDatosVehiculo(string matricula)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Matricula.Equals(matricula))
                {
                    return vehiculo.ToString();
                }
            }
            return null;
        }
        public string getDatosCliente(string nif)
        {
            foreach(Cliente cli in clientes)
            {
                if(cli.Nif.Equals(nif))
                {
                    return cli.ToString();
                }
            }
            return null;
        }
        public List<string> listaClientes()
        {
            List<string> listaClientes = new List<string>();

            foreach (Cliente cliente in clientes)
            {
                listaClientes.Add(cliente.ToString());
            }
            return listaClientes;
        }
        public List<string> listaVehiculos()
        {
            List<string> listaVehiculos = new List<string>();
            foreach (Vehiculo veh in vehiculos)
            {
                listaVehiculos.Add(veh.Matricula + "\t" + veh.Marca + "\t" + veh.Model + "\t" + veh.GetType().Name);
            }
            return listaVehiculos;
        }
        public List<string> listaVehByTipo(int tipo)
        {
            List<string> vehEncontrado = new List<string>();
            switch (tipo)
            {
                case 1:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Coche)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
                case 2:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Moto)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
                case 3:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Camion)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
            }
            return vehEncontrado;
        }
        public string getNombreClienteByNif(string nif)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Nif.Equals(nif))
                {
                    return cliente.Nombre;
                }
            }
            return "";
        }

    }


}

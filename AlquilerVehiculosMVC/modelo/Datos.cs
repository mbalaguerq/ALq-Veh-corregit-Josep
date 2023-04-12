using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
        public void carregaParametres()
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nif = "11111111A";
            cliente1.Nombre = "Josep";

            Cliente cliente2 = new Cliente();
            cliente2.Nif = "22222222B";
            cliente2.Nombre = "Ricardo";

            clientes.Add(cliente1);
            clientes.Add(cliente2);

            Coche coche1 = new Coche();
            coche1.Matricula = "1111ZZ";
            coche1.Marca = "Nisan";
            coche1.Model = "Juke";
            coche1.Puertas = 5;

            Moto moto1 = new Moto();
            moto1.Matricula = "2222XXX";
            moto1.Marca = "Ducati";
            moto1.Model = "Panigale R";
            moto1.Cc = 1199;

            Camion camion1 = new Camion();
            camion1.Matricula = "3333YYY";
            camion1.Marca = "Mercedes";
            camion1.Model = "K1";
            camion1.Kg = 2500;

            vehiculos.Add(coche1);
            vehiculos.Add(moto1);
            vehiculos.Add(camion1);

            Contrato contrato1 = new Contrato();
            contrato1.FechaInicio = DateTime.Parse("01/05/2023");
            contrato1.FechaFin= DateTime.Parse("10/05/2023");
            contrato1.PrecioDia = 60;
            contrato1.Vehiculo = coche1;
            contrato1.Cliente = cliente1;
            contrato.Add(contrato1);

            Contrato contrato2 = new Contrato();
            contrato2.FechaInicio = DateTime.Parse("11/05/2023");
            contrato2.FechaFin = DateTime.Parse("15/05/2023");
            contrato2.PrecioDia = 80;
            contrato2.Vehiculo = moto1;
            contrato2.Cliente = cliente2;
            contrato.Add(contrato2);

            Contrato contrato3 = new Contrato();
            contrato3.FechaInicio = DateTime.Parse("22/05/2023");
            contrato3.FechaFin = DateTime.Parse("25/05/2023");
            contrato3.PrecioDia = 90;
            contrato3.Vehiculo = coche1;
            contrato3.Cliente = cliente2;
            contrato.Add(contrato3);

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
        public List<string> listarContratos()
        {
            List <string> lista = new List<string>();

            foreach (Contrato contrato in contrato)
            {
                lista.Add("Data Inici: " +  contrato.FechaInicio.ToShortDateString() + "\n" +  
                          "Data Final: " + contrato.FechaFin.ToShortDateString() + "\n" +
                          "Dades Vehicle:\n" + contrato.Vehiculo.ToString() + "\n" + 
                          "Dades Client:\n" + contrato.Cliente.ToString());
            }
            return lista;
        }
        public void grabarCSV()
        {
            StreamWriter fitxer = new StreamWriter(@"c:\CSV\clientes.csv");
            
            string texto = "";

            foreach (Cliente cliente in clientes)
            {
                texto = cliente.Nif + "," + cliente.Nombre;
                fitxer.WriteLine(texto);
            }
            fitxer.Close();
        }
        public List <string> leerCSV()
        {
            string fichero = @"C:\csv\clientes.csv";
            StreamReader archivo = new StreamReader(fichero);
            string linea;
            List<string> lines = new List<string>();            
           
            while ((linea = archivo.ReadLine()) != null)
            {
                lines.Add(linea);                
            }
            return lines;
        }
        public void carregaCSV()
        {
            Cliente cliente;

            string fichero = @"C:\csv\clientes.csv";
            StreamReader archivo = new StreamReader(fichero);
            string linea;            
            while ((linea = archivo.ReadLine()) != null)
            {
                string[] fila = linea.Split(',');
                cliente = new Cliente();
                cliente.Nif = fila[0];
                cliente.Nombre = fila[1];
                clientes.Add(cliente);
            }
        }
    }


}

using AlquilerVehiculosMVC.controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal class ClienteView
    {
        ClienteController clienteController;
        public ClienteView()
        {
        }
        public ClienteView(ClienteController pClienteController)
        {
            // revibimos por parámetro el controlador qu utilizara la vista
            clienteController = pClienteController;
        }
        public void altaCliente()
        {
            Hashtable clienteHash = new Hashtable();
            Console.Write("Nif: ");
            string nif = Console.ReadLine();

            // para comprobar si el cliente ya existe
            // llamamos al método getNombre que está en el contolador ClienteControler
            // y le enviamos el nif com parámwtro

            string nombre = clienteController.getNombre(nif);
            if (!nombre.Equals(""))
            {
                // si el método getNombre nos devuelve un valor distinto de "" es que ya existe
                Console.WriteLine("El cliente con nif " + nif + " ya extiste con nombre: " + nombre);
            }
            else
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                clienteHash.Add("Nif", nif);
                clienteHash.Add("Nombre", nombre);

                // en este punto llamamos al método altaCliente en el controlador
                // de esta forma simulamos que clicamos el botón "Correcto" en
                // una página web. es decir el botón llama al método ubicado
                // en el controlador

                clienteController.altaCliente(clienteHash);
            }
        }
        public void mostrarClientes(List<string> listaClientes)
        {
            Console.WriteLine("Nif     \tNombre");
            Console.WriteLine("========\t=================================");
            foreach (string clienteString in listaClientes)
            {
                Console.WriteLine(clienteString);
            }
        }
        public void eliminarCliente()
        {
            Console.WriteLine("Introdueix Dni Client");
            string nif = Console.ReadLine();
            string datosCliente = clienteController.getDatosCliente(nif);
            string datosCli = datosCliente;
            datosCli.ToLower();
            if (datosCli == null)
            {
                Console.WriteLine("El client no existeix");
            }
            else
            {
                Console.WriteLine("¿Seguro que quieres eliminar? (s/n)");
                string ok = Console.ReadLine();
                if (ok.ToUpper().Equals("S"))
                {
                    clienteController.eliminarCliente(nif);
                }

            }
        }
        public void grabarCSV()
        {
            Console.WriteLine("Llistat de clients en format CSV");            
            clienteController.grabarCSV();
            Console.WriteLine("Les dades s'han escrit al fitxer.");
            Console.WriteLine("Trobaràs el teu llistat a la ubicació: c:\\CSV\\clientes.csv");
            Console.WriteLine();
        }
        public void leerCSV()
        {
            List<string> fila= clienteController.leerCSV();

            Console.WriteLine("Lectura d'arxiu Csv: ");
            Console.WriteLine();
           

            foreach (string filaString in fila) 
            {
                string[] linea = filaString.Split(',');

                for (int i = 0; i < linea.Length; i++)
                {
                    Console.Write(linea[i] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void carregaCSV()
        {
            Console.WriteLine("Càrrega d'arxiu Csv: ");
            Console.WriteLine("Les dades de l'arxiu es grabaràn com a nous clients");
            clienteController.carregaCSV();
        }
    }
}

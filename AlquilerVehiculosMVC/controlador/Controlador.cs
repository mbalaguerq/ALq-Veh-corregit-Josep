using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlquilerVehiculosMVC.vista;
using AlquilerVehiculosMVC.modelo;
using System.Collections;

namespace AlquilerVehiculosMVC.controlador
{
    internal class Controlador
    {
        Datos datos;
        View vista;
        public Controlador(Datos datos, View vista)
        {
            this.datos = datos;
            this.vista = vista;
        }
        public Controlador()
        {
            datos = new Datos();
            vista = new View();
            datos.carregaParametres();
        }
        public void gestionMenu()
        {
            bool salir = false;
            string opcion;

            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "1":
                        altaVehiculo();
                        break;
                    case "2":
                        altaCliente();
                        break;
                    case "3":
                        mostrarVehiculos();
                        break;
                    case "4":
                        mostrarClientes();
                        break;
                    case "5":
                        mostrarVehByTipo();
                        break;
                    case "6":
                        eliminarVehiculo();
                        break;
                    case "7":
                        altaContrato();
                        break;
                    case "8":
                        listarContratos();
                        break;
                    case "9":
                        grabarCSV();
                        break;
                    case "A":
                        leerCSV();
                        break;
                    case "B":
                        carregaCSV();
                        break;

                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);
        }
        private void altaVehiculo()
        {
            Hashtable vehiculoHash;
            int tipoVehiculo;
            tipoVehiculo = VehiculosView.seleccionarTipoVehiculo();

            switch (tipoVehiculo)
            {
                case 1:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addCoche(vehiculoHash);
                    break;
                case 2:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addMoto(vehiculoHash);
                    break;
                case 3:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addCamion(vehiculoHash);
                    break;
            }
        }
        private void mostrarVehByTipo()
        {
            int tipoVehiculo;
            tipoVehiculo = VehiculosView.seleccionarTipoVehiculo();
            List<string> listaVeh = datos.listaVehByTipo(tipoVehiculo);
            VehiculosView.mostrarVehiculos(listaVeh, tipoVehiculo);
            //VehiculosView.mostrarVehiculos(datos.listaVehByTipo(tipoVehiculo));
        }
        private void altaCliente()
        {
            // 1) derivar la logica/control a un controlador especifico de clientes
            // no podemos hacer un new datos ya que perderiamos todos los datos
            // por lo tanto hay que enviar por parámetro el objeto datos al nuevo
            // controlador
            
            ClienteController clienteController = new ClienteController(datos);

            // 2) Además como que desde la vista necesitamos consultar si el cliente ya
            // existe, pues desde la vista necesitamos poder acceder al controlador,
            // Así pues, para poder acceder al controlador desde la vista, 
            // necesitamos enviarle a la vista el controlador por parámetro

            ClienteView clienteView = new ClienteView(clienteController);

            // ahora ya podemos llanar al metodo altaCliente qe está
            // en la vista ClienteView

            clienteView.altaCliente();
        }
        private void eliminarVehiculo()
        {
            VehiculoController vehiculoController = new VehiculoController(datos);
            EliminarVehiculoView eliminarVehiculoView = new  EliminarVehiculoView(vehiculoController);
            eliminarVehiculoView.eliminarVehiculo();
        }
        private void eliminarCliente()
        {
            ClienteController clienteController = new ClienteController(datos);
            ClienteView eliminarClienteView =new ClienteView(clienteController);
            eliminarClienteView.eliminarCliente();
        }
        private void mostrarClientes()
        {
            ClienteView clienteView = new ClienteView();
            List<string> listaclientes = datos.listaClientes();
            clienteView.mostrarClientes(listaclientes);
            //ClienteView.mostrarClientes(datos.listaClientes());
        }
        private void mostrarVehiculos()
        {
            List<string> listaVehiculos = datos.listaVehiculos();
            VehiculosView.mostrarVehiculos(listaVehiculos, 4);
            //VehiculosView.mostrarVehiculos(datos.listaVehiculos());
        }
        private void altaContrato()
        {
            ContratoController contratoController = new ContratoController(datos);
            ClienteController clienteController = new ClienteController(datos);
            ContratoView contratoView = new ContratoView(contratoController, clienteController);
            contratoView.altaContrato();
            
        }
        private void listarContratos()
        {
            ContratoController contratoController = new ContratoController(datos);
            ClienteController clienteController = new ClienteController(datos);
            ContratoView contratoView = new ContratoView(contratoController, clienteController);
            contratoView.listarContratos();
        }
        public void grabarCSV()
        {
            ClienteController clienteController = new ClienteController(datos);
            ClienteView clienteView = new ClienteView(clienteController);
            clienteView.grabarCSV();
        }
        public void leerCSV()
        {
            ClienteController clienteController = new ClienteController(datos);
            ClienteView clienteView = new ClienteView(clienteController);
            clienteView.leerCSV();
        }
        public void carregaCSV()
        {
            ClienteController clienteController = new ClienteController(datos);
            ClienteView clienteView = new ClienteView(clienteController);
            clienteView.carregaCSV();
        }
    }
}


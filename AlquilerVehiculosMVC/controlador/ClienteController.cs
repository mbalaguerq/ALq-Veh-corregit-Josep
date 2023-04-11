using AlquilerVehiculosMVC.modelo;
using AlquilerVehiculosMVC.vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.controlador
{
    internal class ClienteController
    {
        Datos datos;
       
        public ClienteController(Datos pDatos)
        {
            // no hacemos un new datos , sino que recibimos el objeto datos
            // porr parametro con sus List/arraylist llenos de datos
            datos = pDatos;    
        }

        public void altaCliente(Hashtable clienteHash)
        {
            // este método solo llama a la clase datos para dar de alta un cliente
            // y le envia los datos que hemos recibido de la vista
            datos.addCliente(clienteHash);
        }
        public string getNombre(string nif)
        {
            // llamamos al método getNombreClienteByNif de la clase datos
            // para buscar el nombre del cliente

            string nombre = datos.getNombreClienteByNif(nif);
            return nombre;

        //  es lo mismo pero en un solo paso, reeviamos lo qu recibios del 
        //  getNombreClienteByNif de datos
        //  return datos.getNombreClienteByNif(nif);
        }
        public string getDatosCliente(string nif)
        {
            string datosCliente;
            datosCliente = datos.getDatosCliente(nif);
            return datosCliente;
        }
        public void eliminarCliente(string nif)
        {
            datos.eliminarCLiente(nif);
        }

        public void grabarCSV()
        {
            datos.grabarCSV();
        }
    }
}

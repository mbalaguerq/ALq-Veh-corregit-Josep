using AlquilerVehiculosMVC.controlador;
using AlquilerVehiculosMVC.modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal class ContratoView
    {
        ContratoController contratoController;
        ClienteController clienteController;
        public ContratoView() { }
        public ContratoView(ContratoController pcontratoController, ClienteController pclienteController)
        {
            contratoController = pcontratoController;
            clienteController = pclienteController;
        }
        public void altaContrato()
        {
            Hashtable contratoHash = new Hashtable();

            string matricula, fechaInicio, fechaFin;
            decimal precio;
            Console.WriteLine("Nuevo Contrato: ");
            Console.WriteLine();
            Console.Write("Nif cliente: ");
            string nif = Console.ReadLine();
            //comprobamos si el cliente existe. Llamamos al método getNombre que está
            // en el contolador ClienteControler y le enviamos el nif con parámetro
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
            }
            contratoHash.Add("NIf", nif);
            contratoHash.Add("Nombre", nombre);

            Console.Write("\nMatricula: ");
            matricula = Console.ReadLine();
            string vehiculo = contratoController.getVehiculobytipo(matricula);
            if (vehiculo == null)
            {
                Console.WriteLine("El vehiculo no existe");
            }
            else
            {
                Console.Write("Fecha inicio dd/mm/aaaa: ");
                fechaInicio = Console.ReadLine();
                Console.Write("Fecha fin dd/mm/aaaa: ");
                fechaFin = Console.ReadLine();
                Console.Write("Precio: ");
                precio = Decimal.Parse(Console.ReadLine());

                contratoHash.Add("Fecha Inicio", fechaInicio);
                contratoHash.Add("Fecha Fin", fechaFin);
                contratoHash.Add("Precio", precio);

                contratoController.addVehiculo(contratoHash); 


            }
        }
    }
   
}

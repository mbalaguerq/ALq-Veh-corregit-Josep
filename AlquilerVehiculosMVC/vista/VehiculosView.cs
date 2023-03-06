using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal static class VehiculosView
    {

        public static int seleccionarTipoVehiculo()
        {
            int opcion;

            do
            {
                Console.WriteLine("1) Coche 2) Moto 3) Camión 0) Salir");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 0 || opcion > 3);
            return opcion;
        }

        public static Hashtable addVehiculo(int tipoVehiculo)
        {
            Hashtable vehiculoHash = new Hashtable();

            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string model = Console.ReadLine();
            
            vehiculoHash.Add("Matricula", matricula); //adding a key/value using the Add() method
            vehiculoHash.Add("Marca", marca);
            vehiculoHash.Add("Model", model);

            switch (tipoVehiculo)
            {
                case 1:
                    Console.Write("Puertas: ");
                    int puertas = int.Parse(Console.ReadLine());
                    Console.Write("Plazas: ");
                    int plazas = int.Parse(Console.ReadLine());
                    vehiculoHash.Add("Plazas", plazas);
                    vehiculoHash.Add("Puertas", puertas);
                    break;

                case 2:
                    Console.Write("cc: ");
                    int cc = int.Parse(Console.ReadLine());
                    vehiculoHash.Add("cc", cc);
                    break;
                case 3:
                    Console.Write("kg: ");
                    int kg = int.Parse(Console.ReadLine());
                    vehiculoHash.Add("kg", kg);
                    break;
            }













            return vehiculoHash;
        }
        public static void mostrarVehiculos(List<string> listaVehiculos,int tipo)
        {
            switch (tipo)
            { case 1:
                    Console.WriteLine("Matricula\tMarca    \tModelo     \tPuertas     \tPlazas");
                    Console.WriteLine("==============================================================");
                    break;
                case 2:
                    Console.WriteLine("Matricula\tMarca    \tModelo     \tcc");
                    Console.WriteLine("==============================================================");
                    break;
                case 3:
                    Console.WriteLine("Matricula\tMarca    \tModelo" +
                        "" +
                        "     \tKg");
                    Console.WriteLine("==============================================================");
                    break;
                case 4:
                    Console.WriteLine("Matricula\tMarca    \tModelo     \tTipo");
                    Console.WriteLine("==============================================================");
                    break;
            }
            
            foreach (string vehiculoString in listaVehiculos)
            {
                Console.WriteLine(vehiculoString);
            }
        }
    }
}

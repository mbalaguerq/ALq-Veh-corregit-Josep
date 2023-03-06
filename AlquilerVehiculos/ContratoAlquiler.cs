using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class ContratoAlquiler
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private decimal precioDia;

        private Vehiculo vehiculo;
        private Cliente cliente;
    
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public decimal PrecioDia { get => precioDia; set => precioDia = value; }
        internal Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }

        public int nDias()
        {
            return (FechaFin - fechaInicio).Days;
        }

        public Decimal costeTotal()
        {
            return nDias() * precioDia;
        }

        public override string ToString()
        {
            return "Matricula: " + vehiculo.Matricula + " Cliente: " + cliente.Nombre + " Fecha: " + fechaInicio;   
        }


    }
}

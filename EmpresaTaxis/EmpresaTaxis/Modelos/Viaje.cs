using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTaxis.Enums;
namespace EmpresaTaxis.Modelos
{
    public class Viaje
    {
        public Cliente Cliente { get; private set; }
        public Conductor Conductor { get; private set; }
        public DateTime Fecha { get; private set; }
        public double  Distancia { get; private set; }
        public TipoVehiculo TipoVehiculo { get; private set; }
        public double TarifaBase { get; private set; }

        public double DescuentoMiembro { get; private set; }
        public double CostoAdicional { get; private set; }
        public Viaje(Cliente cliente, Conductor conductor, DateTime fecha, double distancia, TipoVehiculo tipoVehiculo, double tarifaBase, double descuentoMiembro, double costoAdicional)
        {
            Cliente = cliente;
            Conductor = conductor;
            Fecha = fecha;
            Distancia = distancia;
            TipoVehiculo = tipoVehiculo;
            TarifaBase = tarifaBase;
            CostoAdicional = costoAdicional;
        }
        public double CalcularCosto()
        {
            if (Cliente.IsFiel)
            {
                return (CostoAdicional * Distancia + TarifaBase )* 0.9;
            }
            else
            {
                return (CostoAdicional * Distancia + TarifaBase);
            }
        }
        public void FinalizarViaje()
        {
            Conductor.CambiarLibre();
        }

    }
}

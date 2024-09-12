using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTaxis.Modelos
{
    public class Conductor
    {
        public string Nombre { get;private set; }
        public string NumeroLicencia { get;private set; }
        public bool IsLibre { get; private set; } = true;

        public Conductor(string nombre, string numeroLicencia, bool isLibre)
        {
            Nombre = nombre;
            NumeroLicencia = numeroLicencia;
        }
        public void CambiarLibre()
        {
            IsLibre = !IsLibre;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}\n Numero Licencia: {NumeroLicencia}");
        }
    }
}

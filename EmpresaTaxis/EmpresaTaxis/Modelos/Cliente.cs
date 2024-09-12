using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTaxis.Modelos
{
   public class  Cliente
    {
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public bool IsFiel { get; private set; } = false;

        public Cliente(string nombre, string direccion, bool isFiel)
        {
            Nombre = nombre;
            Direccion = direccion;
  
        }
        public void CambiarFiel()
        {
            IsFiel = !IsFiel;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre {Nombre}\n Direccion: {Direccion}");
            if (IsFiel)
            {
                Console.WriteLine($"Es miembro");
            }
            else {
                Console.WriteLine($"No es miembro");
                }
        }
    }
}

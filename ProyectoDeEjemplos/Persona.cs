using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeEjemplos
{
    public class Persona
    {
        // Atributos
        public string nombre;
        public string apellido;
        public int edad;

        // Acciones
        public void Saludar() {
            Console.WriteLine("Hola, buenas noches");
        }
        public void Caminar(int cantidadPasos) {
            if (cantidadPasos >= 0)
            {
                Console.WriteLine("Estoy caminando " + cantidadPasos + " pasos.");
            }
            else {
                Console.WriteLine("Estoy retrocediento " + Math.Abs(cantidadPasos)+ " pasos.");
            }
        }
    }
}

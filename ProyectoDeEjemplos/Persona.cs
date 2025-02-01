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
        private string _nombre;
        private string _apellido;
        private int _edad;

        public string nombre { 
            get => _nombre; 
            set { 
                if(value.Length >=3 && value.Length <20)
                    _nombre = value;
            } 
        }
        public string apellido { 
            get => _apellido;
            set {
                if (value.Length >= 3 && value.Length < 20)
                    _apellido = value;
            }
        }
        public int edad { 
            get => _edad;
            set {
                if(value >= 4 && value < 18)
                    _edad = value;
            } 
        }
        // Constructores
        public Persona() {
            _nombre = "NN";
            _apellido = "NA";
            _edad = 4;
        }
        public Persona(String nom) {
            _nombre = nom;
            _apellido = "No informa";
            _edad = 0;
        }
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
        public string decirLaHora() {
            string hora = "20:00";
            return hora;
        }
    }
}

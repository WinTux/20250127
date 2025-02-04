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
        public Persona(string nom) {
            _nombre = nom;
            _apellido = "No informa";
            _edad = 0;
        }
        public Persona(string nombre, string apellido, int edad) { 
            this.nombre= nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        // Acciones
        public void Saludar() {
            Console.WriteLine("Hola, buenas noches");
        }
        public void Presentarse() {
            Saludar();
            Console.WriteLine($"Mi nombre es {_nombre} {_apellido} y cuento con {_edad} años.");
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
    public class Estudiante : Persona, ICiudadano { // hereda -->
        private int _matricula;
        private string _carrera;
        public int matricula
        {
            get { return _matricula; }
            set { if(value > 1000) _matricula = value; }
        }
        public string carrera
        {
            get { return _carrera; }
            set { if (value.Length > 3) _carrera = value; }
        }
        public Estudiante(int matricula, string carrera) {
            this.matricula = matricula;
            this.carrera = carrera;
        }
        public Estudiante(string nombre, string apellido, int edad, int matricula, string carrera) : base(nombre,apellido,edad) {
            this.matricula = matricula;
            this.carrera = carrera;
        }
        public void Presentarse() {
            Console.WriteLine($"Hola a todos, me llamo {nombre} {apellido}, tengo {edad} años, estoy en la carrera de {carrera}, cuento con mi matrícula {matricula}. Espero llevarme bien con todos.");
        }

        public void Votar(string partido)
        {
            throw new NotImplementedException();
        }
    }
    public interface ICiudadano {
        public void Votar(string partido);
    }
}

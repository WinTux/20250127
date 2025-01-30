namespace ProgramaPrincipal
{
    
    internal class Programa
    {
        static string nombre = "Pepe";
        static void Main(string[] args)
        {
            int edad = 20;
            Console.WriteLine("Hello, World!");
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            OtroMain(null);

            //Numéricos
            int num = 123; // 123, 0, -2, 2000000
            short num2 = 123; // 123
            byte num3 = 123; // 123
            long num4 = 123; // 123, 2000000

            float num5 = 12.3f; // 12.3
            double num6 = 12.3; // 0.123e2
            num6 = 123.56; // 0.12356e3
            num6 = 0.00034; // 0.34e-3
            num6 = 34.7f;
            num6 = 45; // Z < R
            num5 = num;

            //Texto
            char letra;
            letra = 'w';
            //letra = 'que';
            letra = '8';
            letra = '?';

            string txt;
            txt = "Pepe";
            txt = "Juan \"Pepe\" Perales";
            txt = "Pepe\nPerales";
            txt = "Pepe\tPerales";
            txt = "";
            Console.WriteLine(txt);

            //Logico
            bool casado; // Álgebra booleana, lógica propicisional
            casado = false;
            casado = true;

            // Arreglos
            // Unidimensionales
            string[] roperoMama;
            roperoMama= new string[4];
            roperoMama[2] = "Blusa";
            roperoMama[3] = "Zapatos";

            /*
             
             [     ] 0 
             [     ] 1 
             [Blusa] 2 
             [ zap ] 3 
            ultimoIndice = cantidad - 1
             
             [][][Blusa][Zap]
              0 1 2 3

             */
            Console.WriteLine(roperoMama[2]);
            if (args.Length > 0 && args.Length % 2 == 0)
            {
                /*
                if (args[0] == "-a" && args.Length == 2)
                {
                    Console.WriteLine("Procesando documento " + args[1] + " con el algoritmo Alfa");
                }
                else {
                    if (args[0] == "-b" && args.Length == 2)
                    {
                        Console.WriteLine("Procesando documento " + args[1] + " con el algoritmo Beta");
                    }
                    else {
                        if (args[0] == "-c" && args.Length == 2)
                        {
                            Console.WriteLine("Procesando documento " + args[1] + " con el algoritmo Gamma");
                        }
                        else {
                            Console.WriteLine("Se esperaba con argumento -a, -b o -c");
                        }
                    }
                }*/
                int indice = 0;
                while (indice < args.Length)
                {
                    if (args[indice] == "-a" && args[indice + 1] != null)
                    {
                        Console.WriteLine("Procesando documento " + args[indice + 1] + " con el algoritmo Alfa");
                    }
                    else {
                        if (args[indice] == "-b" && args[indice + 1] != null)
                        {
                            Console.WriteLine("Procesando documento " + args[indice + 1] + " con el algoritmo Beta");
                        }
                        else {
                            if (args[indice] == "-c" && args[indice + 1] != null)
                            {
                                Console.WriteLine("Procesando documento " + args[indice + 1] + " con el algoritmo Gamma");
                            }
                        }
                    }

                    indice++;//indice = indice + 1;
                }
            }
            else {
                Console.WriteLine("Se necesitan argumentos como: -a, -b, -c seguido de un archivo pdf");
            }

            // Estructuras iterativas
            // While (Mientras)
            // Do-While (Hacer-Mientras)
            num = 10;
            do {
                Console.WriteLine("Estoy en Do-While con indice: " + num);
                num++;
            } while (num < 5);
            // for (Para)
            for (int i=5;i > 0;i--) {
                Console.WriteLine("falta "+ i);
            }
            Console.WriteLine("Feliz año nuevo!!");
            for (int i = 1; i<=5;i++) {
                Console.WriteLine("Pasó " + i);
            }
            for (int i = 0; i <= 10;i=i+3) {
                Console.WriteLine("El valor de i: "+i);
            }
            for (int i =0, j = 100;i <100 && j > 0;i++,j-- ) {
                Console.WriteLine("i: " + i+"; j: "+j);
            }
            // Arreglo bidimensional
            int[,] abc = new int[4,4];
            /*
            [ ][ ][ ][ ]
            [ ][ ][ ][ ]
            [ ][ ][ ][ ]
            [ ][ ][ ][ ]

             */
            int[,] xyz = new int[4,2];
            /*
            [ ][ ][ ][ ]
            [ ][ ][ ][ ]


            [ ][ ]
            [ ][ ]
            [ ][ ]
            [ ][ ]
             */
        }

        static void OtroMain(string[] args) {
            Console.WriteLine("Hola mundo, dice " + nombre);
            //Console.WriteLine("La edad es " + edad);
        }
    }

    public class EjemploClase { 
    
    }
}

namespace Auxiliares {
    namespace Desarrollo {
        public class OtraClase {
            
        }
    }
}
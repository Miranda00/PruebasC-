using System;

namespace ComandosSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //SALIDA DE TEXTO SiN ESPACIO
            Console.Write("Esta es una salida de texto sin enter");
            //SALIDA DE TEXTON CON ENTER
            Console.WriteLine ("Esta es una salida de texto con enter");

            //Declarando una variable; tipos: int, double, char, bool, string, etc
            int age,carnet;
            var name = "";
            var lastName = "";
            var carrer = "";

            //Recivir datos de parte del usuario. C# recibe entradas como texto, hay que convertit.
            Console.Write ("\nIngrese su nombre: ");
            name = Console.ReadLine();
            Console.Write ("Ingrese su apellido: ");
            lastName = Console.ReadLine();
            Console.Write ("Ingresela  carrera que esta cursando: ");
            carrer = Console.ReadLine();
            Console.Write ("Ingrese su edad: ");
            age = Convert.ToInt32(Console.ReadLine());            
            Console.Write ("Ingrese su carnet: ");
            carnet = Convert.ToInt32(Console.ReadLine());

            //Concatenar y salida de txto usando datos otorgados por el usuario 
            System.Console.WriteLine("\nBienvenido");
            System.Console.WriteLine($"Nombre: {name} \nApellido: {lastName} \nCarnet: {carnet} \nCarrera: {carrer} \nEdad: {age}");
            */
            //FLUJOS (?)
            System.Console.WriteLine("Ingrese dos numeros para enlistarlos en pantalla");
            Console.Write ("Ingrese numero menor: ");
            int numSmaller = Convert.ToInt32(Console.ReadLine());
            Console.Write ("Ingrese numero mayor: ");
            int numBigger = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Haciendo uso de for");
            for (int i = numSmaller; i <= numBigger; i++)
                Console.Write ($"{i} ");

            System.Console.WriteLine("\nHaciendo uso de while");
            while (numSmaller <= numBigger)
            {
                Console.Write ($"{numSmaller} ");
                numSmaller = numSmaller + 1;
            }

            System.Console.WriteLine("\nHaciendo uso de do while");
            do
            {
                Console.Write ($"{numSmaller} ");
                numSmaller = numSmaller + 1;
            } while (numSmaller <= numBigger);

            //IF ..ELSE -- QUIEN ES MAYOR
            if (numBigger > numSmaller)
            {
                Console.WriteLine("El numero mayor es " + numBigger );
            }
            else
            {
                Console.WriteLine("El numero mayor es " + numSmaller);
            }

            //ARREGLOS 
            string[ ] vocales2 = new string[5]{"a","e","i","o","u"};
            Console.WriteLine(vocales2[3]);
            string[] numeros = new string [4] {"1", "2", "2", "4"};
            
            //recorre el arreglo con un For
            for (int c = 0; c <= 4; c++)
                Console.WriteLine(numeros [c]);
            
            //ARREGLO DE NOMBRES 
            string[] nombres = new string [3] {"Federico", "Carmen", "Alex"};
            
            //Foreach
            //sort ordenar de forma alfabetica
            Array.Sort(nombres);
            foreach (string d in nombres )
            {
                Console.WriteLine("{0} ", d);
                //ToUpper convierte la cadena de texto en mayuscula 
                //ToLower convierte la cadena de texto en minuscula
                Console.WriteLine("{0} ", d.ToUpper());
            }
            
            //Contabilizar los elementos del arreglo
            Console.WriteLine(nombres.Length);
            
            //SWITCH
            int dia = 2;
            switch (dia) 
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no esta disponible");
                    break;
            }
        }
        //funciones 
        //tipo void no devuelve nada
        public static void saludo(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        //tipo int, double, string si pueden devolver 
        public static int suma(int x, int y)
        {
            return x + y;
        }
    }
}
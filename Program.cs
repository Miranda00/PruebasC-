using System;

namespace ComandosSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //FLUJOS (?)

            
        }
    }
}
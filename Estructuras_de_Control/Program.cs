using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_de_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            //int numero1 = 10;
            //string nombre = "Juan"; // string es una cadena de caracteres con comillas dobles
            //char letra = 'A'; // char es un solo caracter con semillas simples
            //decimal precio = 3.14m; //decimal es un numero de coma y la m al final
            //float altura = 1.75f; // float es un numero con coma y la f al final
            //bool esVerdadero = false; // es un valor logico verdadero o falso
            //DateTime fecha = DateTime.Now; // Datetime es para fecha y hora


            //Estructura de control 
            //Console.WriteLine("Bienvenidos"); // Para mostrar en consola 
            //int numero = int.Parse(Console.ReadLine());// Readline = para leer la entrada del usuario
            ////Console.WriteLine("Su edad es: " + numero);
            //Console.WriteLine($"sue edad es:{numero}");// otra forma de concatenar

            //Ejercicio 1
            //Perdirle al usuario las 3 notas donde la primera nota equivale al 20%,
            //segunda nota 30%, tercera nota 50%, se debe calificar de 1 a 5,
            //no se debera permitir que  el usuario ingrese un numero fuera de ese rango,
            //al final debe mostra un mensaje si el estudiante aprobo o no.

            for (int i = 0; i > 5; i++)
            {
                Console.WriteLine("Ingrese su nota 1");
                decimal N1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su nota 2");
                decimal N2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su nota 3");
                decimal N3 = decimal.Parse(Console.ReadLine());
            }

            decimal nota1 = (N1 * 20) / 100;
            decimal nota2 = (N2 * 30) / 100;
            decimal nota3 = (N3 * 50) / 100;

            decimal NotaFinal = (nota1 + nota2 + nota3);
            decimal Nf = (NotaFinal / 3);

            Console.WriteLine($"Su nota es:{NotaFinal}");


            if (Nf >= 3)
            {
                Console.WriteLine("Aprobaste");
            }
            else
            {
                Console.WriteLine("No aprobaste");
            }
        }
    }
}

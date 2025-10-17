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

            ////Ejercicio 1
            //Perdirle al usuario las 3 notas donde la primera nota equivale al 20%,
            //segunda nota 30%, tercera nota 50%, se debe calificar de 1 a 5,
            //no se debera permitir que  el usuario ingrese un numero fuera de ese rango,
            //al final debe mostra un mensaje si el estudiante aprobo o no.


            //    Console.WriteLine("Ingrese su nota 1");
            //    decimal N1 = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese su nota 2");
            //    decimal N2 = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese su nota 3");
            //    decimal N3 = decimal.Parse(Console.ReadLine());


            //    decimal nota1 = (N1 * 20) / 100;
            //    decimal nota2 = (N2 * 30) / 100;
            //    decimal nota3 = (N3 * 50) / 100;

            //    decimal NotaFinal = (nota1 + nota2 + nota3);
            //    decimal Nf = (NotaFinal / 3);

            //    Console.WriteLine($"Su nota es:{NotaFinal}");


            //    if (Nf >= 3)
            //    {
            //        Console.WriteLine("Aprobaste");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No aprobaste");
            //    }










            //Trabajo 17/10/2025

            //1. Desarrolar un algoritmo que permita generar la colilla de pago de los empleados de una empresa,
            //la colilla debe mostrar:

            //-El salario del Empleado
            //-El Valor de Ahorro mensual programado
            //-La suma a deducir por aporte a la Salud  (EPS) 12,5%
            //-La suma de ddeducir por aporte al Fondo de pensiones 16%
            //-Total a recibir
            //-Toda la información que debe de proveer el usuario del programa es el Salario del Empleado y el Valor de Ahorro mensual programado.El programa debe calcular y 
            // y devolver el resto de datos.4

            //decimal EPS = 0.125m;
            //decimal Pension = 0.16m;

            //Console.WriteLine("Ingrese el valor de su salario");
            //decimal Salario = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de Ahorro mensual programadoo");
            //decimal Ahorro = decimal.Parse(Console.ReadLine());

            //decimal A_Salud = (Salario * EPS);
            //decimal A_Pension = (Salario * Pension);

            //decimal Total_Deducciones = A_Salud + A_Pension + Ahorro;
            //decimal Total = Salario - Total_Deducciones;

            //Console.WriteLine("----- COLILLA DE PAGO -----");
            //Console.WriteLine($"Salario bruto:           {Salario:C}");
            //Console.WriteLine($"Ahorro mensual programado:{Ahorro:C}");
            //Console.WriteLine($"Deducción EPS (12.5%):   {A_Salud:C}");
            //Console.WriteLine($"Deducción Pensión (16%): {A_Pension:C}");
            //Console.WriteLine($"Total deducciones:       {Total_Deducciones:C}");
            //Console.WriteLine($"Total a recibir:         {Total:C}");
            //Console.WriteLine("---------------------------");


            //2. En una universidad pueden pagar el valor de su matricula en cuatro cuotas de la siguiente forma

            //-Primera cuota: 40%
            //-Segunda cuota: 25%
            //-Tercera cuota: 20%
            //-Cuarta cuota: 15%


            //decimal primera = 0.40m;
            //decimal segunda = 0.25m;
            //decimal tercera = 0.20m;
            //decimal cuarta = 0.15m;


            //Console.WriteLine("Ingrese el valor de su matricula");
            //decimal Matricula = decimal.Parse(Console.ReadLine());

            //decimal Cuota_1 = Matricula * primera;
            //decimal Cuota_2 = Matricula * segunda;
            //decimal Cuota_3 = Matricula * tercera;
            //decimal Cuota_4 = Matricula * cuarta;


            //Console.WriteLine("----- Pago Matricula por cada cuota -----");
            //Console.WriteLine($"Matricula  {Matricula:C}");
            //Console.WriteLine($"Primera Cuota {Cuota_1:C}");
            //Console.WriteLine($"Segunda Cuota {Cuota_2:C}");
            //Console.WriteLine($"Tercera Cuota {Cuota_3:C}");
            //Console.WriteLine($"Cuarta Cuota {Cuota_4:C}");
            //Console.WriteLine("--------------------------");





            //3. Realice ubn algoritmo que permita realizar el cálculo del siguiente enunciado, se solicita el año de nacimiento del
            //aprendiz, el nombre, la dirección, se requiere conocer la edad de la persona y la información completa ingresada.

            //Console.WriteLine("Ingrese su nombre:");
            //string nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese su dirección:");
            //string direccion = Console.ReadLine();

            //Console.WriteLine("Ingrese su año de nacimiento:");
            //int anioNacimiento = int.Parse(Console.ReadLine());

            //int anioActual = DateTime.Now.Year;

            //int edad = anioActual - anioNacimiento;

            //Console.WriteLine("----- Información del aprendiz -----");
            //Console.WriteLine($"Nombre: {nombre}");
            //Console.WriteLine($"Dirección: {direccion}");
            //Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
            //Console.WriteLine($"Edad: {edad} años");
            //Console.WriteLine("------------------------------------");



            //4. Se tienen tres baldes de agua, uno de cinco litros. otros de tres litros  y otro de un litro;
            //si el de un litro tarda una hora y media en llenarse, resuelva caunto tiempo pueden tardar en llenarse los otros baldes.
            //Si tiene tres baldes, pero desconoce su tamaño debe de resolver el ejercico igualmente.

            //decimal tiempoPorLitro = 1.5m;

            //decimal balde1 = 1;
            //decimal balde3 = 3;
            //decimal balde5 = 5;

            //decimal tiempo1 = balde1 * tiempoPorLitro;
            //decimal tiempo3 = balde3 * tiempoPorLitro;
            //decimal tiempo5 = balde5 * tiempoPorLitro;

            //Console.WriteLine("----- Tiempo de llenado (baldes conocidos) -----");
            //Console.WriteLine($"Balde de 1 litro: {tiempo1} horas");
            //Console.WriteLine($"Balde de 3 litros: {tiempo3} horas");
            //Console.WriteLine($"Balde de 5 litros: {tiempo5} horas");
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine("Si no conoce el tamaño, ingrese los litros de cada balde:");

            //Console.Write("Litros del primer balde: ");
            //decimal baldeA = decimal.Parse(Console.ReadLine());

            //Console.Write("Litros del segundo balde: ");
            //decimal baldeB = decimal.Parse(Console.ReadLine());

            //Console.Write("Litros del tercer balde: ");
            //decimal baldeC = decimal.Parse(Console.ReadLine());


            //decimal tiempoA = baldeA * tiempoPorLitro;
            //decimal tiempoB = baldeB * tiempoPorLitro;
            //decimal tiempoC = baldeC * tiempoPorLitro;

            //Console.WriteLine("\n----- Tiempos personalizados -----");
            //Console.WriteLine($"Balde A ({baldeA} L): {tiempoA} horas");
            //Console.WriteLine($"Balde B ({baldeB} L): {tiempoB} horas");
            //Console.WriteLine($"Balde C ({baldeC} L): {tiempoC} horas");
            //Console.WriteLine("-----------------------------------");


            //5. Una persona tarda 5 horas en subir una montaña de 7 metros, si un escalador desea subir más o menos de la montaña,
            //cuanto tiempo tarda en subir. Debe de resolver el ejercicio. 

            //decimal metros_base = 7m;
            //decimal tiempo_base = 5m;

            //decimal tiempo_por_metro = tiempo_base / metros_base;

            //Console.WriteLine("¿Cuántos metros desea subir?");
            //decimal metros_usuario = decimal.Parse(Console.ReadLine());

            //decimal tiempo_total = tiempo_por_metro * metros_usuario;

            //Console.WriteLine("----------------------------");
            //Console.WriteLine($"Tiempo estimado para subir {metros_usuario} metros: {tiempo_total} horas");


            //6.Un estudiante realiza un prestamo a un plazo de 5 años, donde la tasa fija de interés es del 5% anual, se debe solicitar el monto del préstamo
            //  y se desea calcular la siguiente informacion:

            //-Cuanto dinero se ha pagado de intereses en un año
            //-Cuanto dinero se ha pagado de intereses en el tercer trimestre del año
            //-Cuanto dinero se ha pagado de interes el primer mes
            //-Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses


            decimal tasa = 0.05m;  

            Console.WriteLine("Ingrese el monto del préstamo:");
            decimal montoPrestamo = decimal.Parse(Console.ReadLine());

            decimal interesAnual = montoPrestamo * tasa; 
            decimal interesMensual = interesAnual / 12; 
            decimal interesTrimestral = interesAnual / 4; 

            decimal interesTercerTrimestre = interesTrimestral;

            decimal totalInteres = interesAnual * 5;

            decimal totalPagar = montoPrestamo + totalInteres;

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Interés en un año: {interesAnual:C}");
            Console.WriteLine($"Interés en el tercer trimestre: {interesTercerTrimestre:C}");
            Console.WriteLine($"Interés en el primer mes: {interesMensual:C}");
            Console.WriteLine($"Total a pagar en 5 años (con intereses): {totalPagar:C}");



        }
    }
}

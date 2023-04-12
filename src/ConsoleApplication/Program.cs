//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {

           // for(int i = 0; i < 100000; i++ )
            //{
            //  Train CreandoTrenes = new Train($"{i}");
            //   Console.WriteLine(Train.GetCount());
            //}
        //La memoria se llena antes de llegar al maximo numero de iteraciones del for y por eso en la consola muestra hasta el utlimo numero que llego a contar
            Train T1 = new Train("Last Train To London");
            Train T2 = new Train("Last Train To London");
            Train T3 = new Train("Runaway Train");
            int CuantosTrenesEstanAndando = Train.GetCount();
            T1 = T2;
            T2 = T3;
        //Cuando hacemos T1 = T2 estamos asignando los atributos de T1 A T2 y viceversa(queda con el valor "Last Train to london ")
        //pero cuando hacemos T2 = T3 le estamos asignadno los atributos de t3 a t2 entonces t2 queda como "Runaway Train".      


            T1.StartEngines();
            T2.StartEngines();
            Console.WriteLine($"La cantidad de trenes es: {CuantosTrenesEstanAndando}");
        }
    }
}
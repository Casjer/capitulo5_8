using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {

            string linea;
            for (; ; )
            {
                Console.WriteLine("Aqui tenemos todos los ejercicios del capitulo 5 hastas el capitulo 8");
                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("1- Capitulo 5 ");
                Console.WriteLine("2- Capitulo 6 ");
                Console.WriteLine("3- Capitulo 7 ");
                Console.WriteLine("4- Capitulo 8 ");
                linea = Console.ReadLine();
                Console.Clear();
                switch (linea)
                {
                    case "1":
                        Console.WriteLine("1- factorial de un numero");
                        Console.WriteLine("2- cadena que regresa palabras");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Exercices.ejercicios4_5 E = new Exercices.ejercicios4_5();
                            E.cap5_4();

                        }
                        else
                            if (linea == "2")
                        {
                            Exercices.ejercicios4_5 E = new Exercices.ejercicios4_5();
                            E.cap5_5();
                        }
                        Console.Clear();

                        break;

                    case "2":
                        Console.WriteLine("1- calculo promedio");
                        Console.WriteLine("2- menor calificacion");
                        Console.WriteLine("3- mayor calificacion");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Exercices.ejercicios1_2_3_4_5 E = new Exercices.ejercicios1_2_3_4_5();
                            E.cap6_1();

                        }
                        else
                            if (linea == "2")
                        {
                            Exercices.ejercicios1_2_3_4_5 E = new Exercices.ejercicios1_2_3_4_5();
                            E.cap6_2();
                        }
                        else
                                    if (linea == "3")
                        {
                            Exercices.ejercicios1_2_3_4_5 E = new Exercices.ejercicios1_2_3_4_5();
                            E.cap6_3();
                        }
                        Console.Clear();

                        break;

                    case "3":
                        Console.WriteLine("1- calificaciones");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Exercices.ejercicios1_2_5 E = new Exercices.ejercicios1_2_5();
                            E.cap7_1();

                        }
                        Console.Clear();

                        break;

                    case "4":
                        Console.WriteLine("1- Forma de feha");
                        linea = Console.ReadLine();
                        Console.Clear();
                        if (linea == "1")
                        {
                            Exercices.ejercicios3_5 E = new Exercices.ejercicios3_5();
                            E.cap8_3();

                        }
                        Console.Clear();

                        break;
                }
            }
        }
    }
    
}

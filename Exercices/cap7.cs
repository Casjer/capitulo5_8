using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercices
{
    class ejercicios1_2_5
    {
        public void cap7_1()
        {
            int menor = 100, mayor = 0, calif = 0, tot = 0;


            ArrayList array = new ArrayList();

            array.Add(98);
            array.Add(70);
            array.Add(89);
            array.Add(65);
            array.Add(80);

            foreach (int n in array)
            {

                if (calif < menor)
                {
                    menor = calif;
                }


            }

            foreach (int n in array)
            {

                if (calif > mayor)
                {
                    mayor = calif;
                }

            }

            Console.WriteLine("\nLa calificacion mas baja es: {0}", menor);
            Console.WriteLine("\nLa calificacion mas alta es: {0}", mayor);
            Console.WriteLine("\nEl promedio de calificacion es: {0}\n", array.Count);
        }
    }
}

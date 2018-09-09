using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercices
{
    class ejercicios4_5
    {
        public void cap5_4()
        {
            int numero, factorial = 1;

            Console.WriteLine("digite un numero");
            numero = int.Parse(Console.ReadLine());

            for (int x = 1; x < numero + 1; x++)
            {
                factorial = factorial * x;
            }
            Console.Write("el resultado es : " + factorial);

            Console.ReadKey();
        }

        public void cap5_5()
        {
            int numero;
            Console.WriteLine("Cadena de numero entero del 0 a 10 s\n");

            Console.Write("digite numero :");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10 || numero < 0)
            {
                Console.WriteLine("la cadena de " + numero + "no existe");
                Console.WriteLine("trate de nuevo");
                cap5_5();
            }
            else
            {
                Cadena(numero);
            }
            Console.ReadKey();
        }

        public void Cadena(int numero)
        {
            string[] numeroletra = new string[] { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            Console.WriteLine("Cadena: " + numeroletra[numero]);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
         // CALCULAR LA NOTA PROMEDIO DE N NOTAS
            int[] notas = new int[10];
            //capturar las notas
            for (int i = 0; i < notas.Length; i++)
            {
                //solicitar las notas al usuario
                Console.Write("Escriba la nota {0}: ", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }
            //recorrer el arreglo de notas
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]); //imprime los valroes
            }
            Console.ReadKey();


        }
    }
}

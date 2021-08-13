using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamado al metodo loops
            loops();

            Console.ReadLine();
        }

        ///bucles
        public static void loops()

        {
            int sumatoria = 0;
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //capturar los valores a almacenar en el array 
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Escriba el valaor para el elemento {0}: ", x);
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }

            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON WHILE");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i = i + 1; //i++
            }

            Console.WriteLine("IMPRIME ELEMENTOS CON DO-WHILE");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                inc++;
            } while (inc < numbers.Length);


            Console.WriteLine("IMPRIME ELEMENTOS CON FOR - ARREGLO ORDENADO");
            //llamdao al array y al metodo Sort
            //el metodo sort permite ordennar los datos dentro de un array
            Array.Sort(numbers);
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);

                //sumar lo daros del aray
                sumatoria = sumatoria + numbers[j];
                Console.WriteLine(sumatoria);
            }
            
           
            Console.WriteLine("IMPRIME ELEMENTOS CON FOREACH - ARREGLO INVERTIDO");
            Array.Reverse(numbers); 
            // reevrse permite todos los datos dentro del array
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            // mostramos el valor promedio
            Console.WriteLine("EL VALOR PROMEDIO ES DE: {0}", sumatoria / (numbers.Length));

            
        }

    }
}


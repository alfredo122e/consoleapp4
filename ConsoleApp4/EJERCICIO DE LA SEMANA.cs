using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class EJERCICIO_DE_LA_SEMANA
    {
        static void Main(string[] args)
        {
            //almacena pares de datos y valor
            //definir un diccionario
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            EmployeeList.Add("RHINA LAINEZ", "38 AÑOS");
            EmployeeList.Add("JUAN PINEDA", "40 AÑOS");
            EmployeeList.Add("JACQUELINE CARBAJAL", "21 AÑOS");
            EmployeeList.Add("ALFREDO LAINEZ", "18 AÑOS");

            //leer diccioanrio y leer datos
            foreach (KeyValuePair<string, string> Employee in EmployeeList)
            {
                Console.WriteLine("clave: {0}, valor: {1}", Employee.Key, Employee.Value);

            }

            //ordenar elementos del diccionario 
            var dic = EmployeeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("DICCIONARIO ORDENADO");
            foreach (var item in dic)

            {
                Console.WriteLine("{0}: {1}", item, EmployeeList);

            }

            //contar elementos de un diccioanrio
            Console.WriteLine("Elementos en el diccionario: {0}", EmployeeList.Count);

            Console.ReadKey();

        }
    }
}

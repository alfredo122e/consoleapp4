using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DICCIONARIO
    {
        static void Main(string[] args)

        {
            // Diccionario
            //almacena pares de datos y valor
            //definir un diccionario
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            EmployeeList.Add("JOSE FLORES", "PROGRAMADOR");
            EmployeeList.Add("MIRANDA CAMPOS", "GERENTE");
            EmployeeList.Add("CARMEN VALLADARES", "AEQUITECTA");

            Dictionary<string, int> Students = new Dictionary<string, int>();

            Students.Add("JOSE FLORES", 22);
            Students.Add("MIRANDA CAMPOS", 20);
            Students.Add("CARMEN VALLADARES", 20);

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

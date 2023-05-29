using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Funciones
{
    public class Menu
    {
        public void Opciones()
        {
            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1: suma");
            Console.WriteLine("2: resta");
            Console.WriteLine("3: multiplicacion");
            int opcion =int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingresa el primer valor");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el otro valor");
            int num2 = int.Parse(Console.ReadLine());


            Operaciones operaciones = new Operaciones();
            
            int result = 0;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el primer valor");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el otro valor");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el otro valor");
                    int num5 = int.Parse(Console.ReadLine());
                    result = operaciones.Suma(num1, num2, num3, num4, num5);
                    Console.WriteLine("El resuldos es " + result);
                    break;
                case 2:
                    result = operaciones.Resta(num1, num2);
                    Console.WriteLine("El resuldos es " + result);
                    break;

                case 3:
                        result = operaciones.Multiplicacion(num1, num2);
                    Console.WriteLine("El resultado es " + result);
                    break;
                default:
                    Console.WriteLine("No hay opcion; c");
                    break;
            }
        }
    }
}

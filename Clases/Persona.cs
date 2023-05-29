using Ejercicio_1.Funciones;
using System;

namespace Ejercicio_1.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingresa tu nombre");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu Apellido");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("Ingresa tu Carrera");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu Edad");
            this.Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Edad >= 18)
            {
                Menu menu = new Menu();

                menu.Opciones();
            }
            else
            {
                Console.WriteLine("No puedes hacer las operaciones por no ser legal");
            }
        }


    }


}


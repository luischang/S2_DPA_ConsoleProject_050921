using S2_DPA_ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_DPA_ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nombreCurso = "Desarrollo de Ambiente Web";
            int edad = 20;
            double monto = 350.50;

            var nuevaEdad = 30;
            var nuevoMonto = 340.70;

            Console.WriteLine("El curso es: " + nombreCurso);

            var persona1 = new Persona();
            persona1.dni = "44556677";
            persona1.nombreCompleto = "Paolo Guerrero";
            persona1.telefono = 4455614;

            var persona2 = new Persona()
            {
                dni="55887799",
                nombreCompleto = "Gianluca Lapadula",
                telefono = 1122445
            };

            var persona3 = new Persona("66995533", "Andre Carrillo", 5566956);

            var listadoPersona = new List<Persona>();
            listadoPersona.Add(persona1);
            listadoPersona.Add(persona2);
            listadoPersona.Add(persona3);

            foreach (var item in listadoPersona)
            {
                Console.WriteLine(item.nombreCompleto + " " + item.dni);
            }

            var busqueda = listadoPersona.Where(x => x.dni == "55887799").FirstOrDefault();

            Console.WriteLine("Se encontró a: " + busqueda.nombreCompleto);

        }
    }
}

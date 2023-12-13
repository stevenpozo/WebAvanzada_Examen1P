using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevenPozo_Exam1P
{
    internal class Estudiante
    {
        //Atributos de la clase estudiante
        string Nombre;
        int Edad;
        double Calificacion;

        //constructor de la clase estudiante
        public Estudiante(string Nombre, int Edad, double Calificacion)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Calificacion = Calificacion;
        }

        public Estudiante()
        {

        }

        //ejercicio 3

        public void MostrarDatosEstudiante()
        {
            Nombre = "Steven";
            Edad = 21;
            Calificacion = 19.34;

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Calificación: {Calificacion}");
            Console.WriteLine("Presione enter para avanzar");
            Console.ReadLine();
        }


        //ejercicio 4
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Calificación: {Calificacion}");
            Console.WriteLine("Presione enter para avanzar");
            Console.ReadLine();
        }
    }

}

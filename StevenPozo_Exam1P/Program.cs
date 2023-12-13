using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevenPozo_Exam1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            Estudiante estudiante1 = new Estudiante();
            Estudiante estudiante2 = new Estudiante("Steven", 21, 18.50);
            EstudianteGraduado estudiante3 = new EstudianteGraduado("Steven", 21, 18.50, "Doctor");

            //ejercicio1
            Console.WriteLine("Ejercicio 1");
            programa.VariablesYOperadores();

            //ejercicio2
            Console.WriteLine("Ejercicio 2");
            programa.EstructurasDeControl();

            //ejercicio3 inicializado los atributos directamente en su funcion
            Console.WriteLine("Ejercicio 3");
            estudiante1.MostrarDatosEstudiante();

            //ejercicio4 inicializado sus atributos desde su contructor
            Console.WriteLine("Ejercicio 4");
            estudiante2.MostrarInformacion();

            //ejercicio5 - añadimos el titulo al estuidante: 
            Console.WriteLine("Ejercicio 5");
            estudiante3.MostrarInformacion2();
            Console.WriteLine("Presione enter para terminar el programa");


        }

        //EJERCICIO 1
        public void VariablesYOperadores()
        {
            //declaramos las dos variables numericas y la variable donde se almacenará la suma
            int numero1;
            int numero2;
            int resultado;

            //inicializamos las dos variables con datos numericos
            numero1 = 2; numero2 = 3;

            //se almacena la suma en resutado
            resultado = numero1 + numero2;

            Console.WriteLine("La suma entre " + numero1 + " y " + numero2 + " es " + resultado);
            Console.WriteLine("Presione enter para avanzar");
            Console.ReadLine();
        }


        //  EJERCICIO 2
        public void EstructurasDeControl()
        {
            //se inicializa con la edad de 10 años, el cual deberia darme como resultado que es menor de edad
            int edad = 10;

            //si es edad es mas de 18 es mayor y si es menos de 18 es menor
            if(edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else{
                Console.WriteLine("Es menor de edad");
            }
            Console.WriteLine("Presione enter para avanzar");
            Console.ReadLine();
        }


    }
}

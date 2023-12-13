using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevenPozo_Exam1P
{
    internal class EstudianteGraduado : Estudiante
    {
        // atributo titulo
        public string Titulo { get; set; }

        // Constructor 
        public EstudianteGraduado(string Nombre, int Edad, double Calificacion, string Titulo)
            : base(Nombre, Edad, Calificacion)
        {
            this.Titulo = Titulo;
        }

        //metodo que muestra la informacion con los datos  de estudiante y el titulo adicional
        public void MostrarInformacion2()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine("Presione enter para terminar");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Juan Perez";
            alumno1.Matricula = "174258";
            alumnos.Add(new Alumno());

            Materia matematicas = new Materia();

            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "M1245";

            //Agregamos ese elemento a la lista
            alumno1.Materias.Add(new Materia());
            alumno1.Materias.Add(matematicas);

            alumno1.Materias[0].Nombre = "Historia";
            alumno1.Materias[0].Identificador = "H1245";

            alumno1.Materias.Add(new Materia());
            alumno1.Materias[2].Nombre = "Español";
            alumno1.Materias[2].Identificador = "E1245";

            //alumno.Materias.RemoveAt(1); //Eliminar un elemento
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear(); //Vaciar la Lista


            Console.WriteLine("Alumno: " + alumno1.Nombre);
            Console.WriteLine("Número de Materias: " + alumno1.Materias.Count);

            /*for (int i = 0; i < alumno.Materias.Count; i++)
            {
                Console.WriteLine("Materia: " + alumno.Materias[i].Nombre);
            }*/

            foreach(Materia materia in alumno1.Materias) // foreach( tipo de dato(la clase) in coleccion) <- Ciclo especial para colecciones
             {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Maria Guitierrez";
            alumno2.Matricula = "176158";
            alumnos.Add(new Alumno());

            Materia quimica = new Materia();
            quimica.Nombre = "Química";
            quimica.Identificador = "Q1245";
            alumno2.Materias.Add(new Materia());

            Materia algebra = new Materia();
            algebra.Nombre = "Álgebra";
            quimica.Identificador = "A1245";
            alumno2.Materias.Add(new Materia());

            Materia fisica = new Materia();
            fisica.Nombre = "Física";
            fisica.Identificador = "F1245";
            alumno2.Materias.Add(new Materia());

            //Alumno 3

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Manuel Casares";
            alumno3.Matricula = "176148";
            alumnos.Add(new Alumno());

            Materia calculo = new Materia();
            calculo.Nombre = "Cálculo";
            calculo.Identificador = "Q1245";
            alumno3.Materias.Add(new Materia());

            Materia mercadotecnia = new Materia();
            mercadotecnia.Nombre = "Mercadotecnia";
            mercadotecnia.Identificador = "M1245";
            alumno3.Materias.Add(new Materia());

            Materia programacion = new Materia();
            programacion.Nombre = "Programación";
            programacion.Identificador = "F1245";
            alumno3.Materias.Add(new Materia());

            //Alumno 4

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Ignacia Chavez";
            alumno4.Matricula = "176148";
            alumnos.Add(new Alumno());

            Materia fe = new Materia();
            fe.Nombre = "Fé";
            fe.Identificador = "F5245";
            alumno4.Materias.Add(new Materia());

            Materia civica = new Materia();
            civica.Nombre = "Cívica";
            civica.Identificador = "C1245";
            alumno4.Materias.Add(new Materia());

            Materia etica = new Materia();
            etica.Nombre = "Ética";
            etica.Identificador = "E1245";
            alumno4.Materias.Add(new Materia());


            Console.WriteLine("Alumno: " + alumno2.Nombre);
            Console.WriteLine("Número de Materias: " + alumno2.Materias.Count);

            Console.ReadLine();
        }
    }
}

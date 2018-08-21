using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Nombre {get;set;}
        public string Matricula { get; set; }

        public List<Materia> Materias { get; set; }// Lista <tipo de dato> no se limita a lo que es el int float string, sio que tambien se puede utilizar una clase

        public Alumno()  //Constructor
        {
            Materias = new List<Materia>();
        }
    }
}

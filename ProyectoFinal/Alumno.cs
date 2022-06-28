using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Alumno
    {
        public DateTime fecha { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string nombre { get; set; }

        public string curso { get; set; }
        public string seccion { get; set; }
        public string docente { get; set; }
        public string turno { get; set; }

        public float exam1 { get; set; }
        public float exam2 { get; set; }
        public float parcial { get; set; }
        public float final { get; set; }
        public float promedio { get; set; }
        
    }
}

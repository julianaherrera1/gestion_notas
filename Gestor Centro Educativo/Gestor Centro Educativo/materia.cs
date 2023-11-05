using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Centro_Educativo
{
    public class materia
    {
        public static class variables_globales
        {
            public static List<matematicas> estudiante_matematicas = new List<matematicas> { };
            public static List<ciencias> estudiante_ciencias = new List<ciencias> { };
            public static List<español> estudiante_español = new List<español> { };
        }
        public class matematicas
        {
            public string estudiante { get; set; }
            public string primernota { get; set; }
            public string segundanota { get; set; }
            public string tercernota { get; set; }
            public matematicas(string _estudiante,string _primernota, string _segundanota, string _tercernota)
            {
                estudiante = _estudiante;
                primernota = _primernota;
                segundanota = _segundanota;
                tercernota = _tercernota;
            }
        }
        public class ciencias
        {
            public string estudiante { get; set; }
            public string primernota { get; set; }
            public string segundanota { get; set; }
            public string tercernota { get; set; }
            public ciencias(string _estudiante,string _primernota, string _segundanota, string _tercernota)
            {
                estudiante = _estudiante;
                primernota = _primernota;
                segundanota = _segundanota;
                tercernota = _tercernota;
            }
        }
        public class español
        {
            public string estudiante { get; set; }
            public string primernota { get; set; }
            public string segundanota { get; set; }
            public string tercernota { get; set; }
            public español(string _estudiante,string _primernota, string _segundanota, string _tercernota)
            {
                estudiante = _estudiante;
                primernota = _primernota;
                segundanota = _segundanota;
                tercernota = _tercernota;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Centro_Educativo
{
    public class persona
    {
        public string user { get; set; }
        public string password { get; set; }
        public string type { get; set; }

        public persona(string _user, string _password, string _type)
        {
            user = _user;
            password = _password;
            type = _type;
        }
        public static class variables_globales
        {
            public static List<persona> usuarios = new List<persona> { };
        }
        
    }
}

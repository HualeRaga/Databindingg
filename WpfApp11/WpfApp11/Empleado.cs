using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class Empleado
    {
        public string Nombre { get; set; }

        public string Titulo { get; set; }


        public static Empleado GetEmpleado()
        {
            var emp = new Empleado()
            {
                Nombre = "Hugo Ramos",
                Titulo = "Experto en Drogas"
            };
            return emp;
        }



 
    }
}

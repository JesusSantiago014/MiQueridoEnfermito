using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMiQuerido
{
    public class Empleado
    {

        public string NombreEmpleado { get; set; }
        public string Sexo { get; set; }
        public override string ToString()
        {
            return string.Format("{0} ({1}) ", NombreEmpleado, Sexo);
        }
    }
}

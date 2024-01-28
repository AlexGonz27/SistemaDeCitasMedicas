using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMedicas.Clases
{
    public class Paciente
    {
        public int CI { get; set; }
        public string Nombre { get; set; } 
        public int Edad { get; set; }
        public string Diagnostico { get; set; }
        public string Sexo { get; set; }
        public string Discapacidad { get; set; }
        public string Especialidad { get; set; }
        public string FechaCita { get; set; }

    }
}

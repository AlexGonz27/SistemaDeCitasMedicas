using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMedicas.Clases
{
    public class DataPaciente
    {
        List<Paciente> dataPacientes = new List<Paciente>();

        public void guardar(Paciente datoP)
        {
            dataPacientes.Add(datoP);
            escribirArchivo(dataPacientes);
        }
        public Paciente Elemento(int CI)
        {
            return dataPacientes.ElementAt(CI);
        }

        public int Tamanio()
        {
            return dataPacientes.Count();
        }

        public int Buscar(int CI)
        {
            for (int i = 0; i < Tamanio(); i++)
            {
                if (Elemento(i).CI == CI)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Eliminar(int pos)
        {
            dataPacientes.RemoveAt(pos);
            escribirArchivo(dataPacientes);
        }

        public void actualizar(Paciente datoP, int pos)
        {
            Eliminar(pos);
            dataPacientes.Insert(pos,datoP);
            escribirArchivo(dataPacientes);
        }

        //Generea archivo temporal para cambiar datos
        private void escribirArchivo(List<Paciente> dataPacientes)
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes.txt",FileMode.Create,FileAccess.ReadWrite);
            StreamWriter stream = new StreamWriter(filestream);
            foreach(Paciente dato in dataPacientes)
            {
                string cadena = Convert.ToString(dato.CI) 
                    + "," + Convert.ToString(dato.Nombre) 
                    + "," + Convert.ToString(dato.Edad) 
                    + "," + Convert.ToString(dato.Diagnostico) 
                    + "," + Convert.ToString(dato.Sexo) 
                    + "," + Convert.ToString(dato.Discapacidad) 
                    + "," + Convert.ToString(dato.Especialidad) 
                    + "," + Convert.ToString(dato.FechaCita);
                stream.WriteLine(cadena);
            }
            stream.Close();
            filestream.Close();
        }

        //Carga todos los datos del archivo
        public List<Paciente> cargarArchivo()
        {
            StreamReader streamReader = new StreamReader("Pacientes.txt");
            dataPacientes.Clear();
            String[] filaActual = null;
            Paciente dato = null;
            while (streamReader.Peek() != -1)
            {
                dato = new Paciente();
                filaActual = streamReader.ReadLine().Split(",");
                dato.CI = Convert.ToInt32(filaActual.ElementAt(0));
                dato.Nombre = filaActual.ElementAt(1);
                dato.Edad = Convert.ToInt32(filaActual.ElementAt(2));
                dato.Diagnostico = filaActual.ElementAt(3);
                dato.Sexo = filaActual.ElementAt(4);
                dato.Discapacidad = filaActual.ElementAt(5);
                dato.Especialidad = filaActual.ElementAt(6);
                dato.FechaCita = filaActual.ElementAt(7);

                dataPacientes.Add(dato);
            }
            streamReader.Close();
            return dataPacientes;
        }
        private void escribirArchivo_M(List<Paciente> dataPacientes)
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes_M.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter stream = new StreamWriter(filestream);
            foreach (Paciente dato in dataPacientes)
            {
                string cadena = Convert.ToString(dato.CI)
                    + "," + Convert.ToString(dato.Nombre)
                    + "," + Convert.ToString(dato.Edad)
                    + "," + Convert.ToString(dato.Diagnostico)
                    + "," + Convert.ToString(dato.Sexo)
                    + "," + Convert.ToString(dato.Discapacidad)
                    + "," + Convert.ToString(dato.Especialidad)
                    + "," + Convert.ToString(dato.FechaCita);
                stream.WriteLine(cadena);
            }
            stream.Close();
            filestream.Close();
        }

        public List<Paciente> cargarArchivo_M ()
        {
            StreamReader streamReader = new StreamReader("Pacientes_M.txt");
            dataPacientes.Clear();
            String[] filaActual;
            Paciente dato = null;
            while (streamReader.Peek() != 1)
            {
                dato = new Paciente();
                filaActual = streamReader.ReadLine().Split(",");
                dato.CI = Convert.ToInt32(filaActual.ElementAt(0));
                dato.Nombre = filaActual.ElementAt(1);
                dato.Edad = Convert.ToInt32(filaActual.ElementAt(2));
                dato.Diagnostico = filaActual.ElementAt(3);
                dato.Sexo = filaActual.ElementAt(4);
                dato.Discapacidad = filaActual.ElementAt(5);
                dato.Especialidad = filaActual.ElementAt(6);
                dato.FechaCita = filaActual.ElementAt(7);

                dataPacientes.Add(dato);
            }
            streamReader.Close();
            return dataPacientes;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMedicas.Clases
{
    public class DataPaciente
    {
        //Se crea la lista de pacientes
        List<Paciente> dataPacientes = new List<Paciente>();
        //Procedimiento para guardar todos los datos del archivo
        public void guardar()
        {
            cargarArchivo_temp();
            escribirArchivo(dataPacientes);
        }
        public void cargar()
        {
            cargarArchivo();
            escribirArchivo_temp(dataPacientes);
        }
        //Procedimiento para guardar los datos de un paciente en la lista y el archivo temporal
        public void guardar_temp(Paciente datoP)
        {
            dataPacientes.Add(datoP);
            escribirArchivo_temp(dataPacientes);
        }
        //Funcion para extraer los datos de un paciente en especifico
        public Paciente Elemento(int CI)
        {
            return dataPacientes.ElementAt(CI);
        }
        //Funcion para retornar el tamaño de la lista
        public int Tamanio()
        {
            return dataPacientes.Count();
        }
        //Funcion para retornar la cantidad de discapacitados
        public int cant_Discapacitados()
        {
            int cant = 0;
            for (int i = 0; i < Tamanio(); i++)
            {
                if (Elemento(i).Discapacidad == "Si")
                {
                    cant ++;
                }
            }
            return cant;
        }
        //Funcion para retornar la cantidad de pacientes Masculinos
        public int cant_Masculinos()
        {
            int cant = 0;
            for (int i = 0; i < Tamanio(); i++)
            {
                if (Elemento(i).Sexo == "Masculino")
                {
                    cant++;
                }
            }
            return cant;
        }
        //Funcion para retornar la cantidad de pacientes Femeninos
        public int cant_Femeninas()
        {
            int cant = 0;
            for (int i = 0; i < Tamanio(); i++)
            {
                if (Elemento(i).Sexo == "Femenino")
                {
                    cant++;
                }
            }
            return cant;
        }
        //Funcion para buscar la posicion de un paciente en especifico
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
        //Procedimiento para eliminar un paciente en su devida posicion
        public void Eliminar(int pos)
        {
            dataPacientes.RemoveAt(pos);
            escribirArchivo_temp(dataPacientes);
        }
        //Procedimiento para actualizar los datos de un paciente existente
        public void actualizar(Paciente datoP, int pos)
        {
            Eliminar(pos);
            dataPacientes.Insert(pos,datoP);
            escribirArchivo_temp(dataPacientes);
        }

        //Generea archivo o sobreescibe un archivo para ingresar los nuevos datos de los pacientes
        public void escribirArchivo(List<Paciente> dataPacientes)
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes.txt",FileMode.Create,FileAccess.ReadWrite);
            StreamWriter stream = new StreamWriter(filestream);
            dataPacientes = dataPacientes.OrderBy(p => p.CI).ToList();
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

        //Carga todos los datos del archivo
        public List<Paciente> cargarArchivo()
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(filestream);
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
        //Generea o sobreescibe un archivo temporal para ingresar los nuevos datos de los pacientes
        public void escribirArchivo_temp(List<Paciente> dataPacientes)
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes_temp.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter stream = new StreamWriter(filestream);
            dataPacientes = dataPacientes.OrderBy(p => p.CI).ToList();
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

        //Carga todos los datos del archivo temporal
        public List<Paciente> cargarArchivo_temp()
        {
            FileStream filestream = File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Pacientes_temp.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(filestream);
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
    }
}

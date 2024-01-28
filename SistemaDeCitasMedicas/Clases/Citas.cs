using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMedicas.Clases
{
    internal class Citas
    {
        DataPaciente dataPacientes = new DataPaciente();
        public String guardar(Paciente datoP)
        {
            dataPacientes.guardar(datoP);
            return "Datos guardados"; 
        }
        public String Actualizar(int pos,Paciente datoP)
        {
            dataPacientes.actualizar(datoP,pos);
            return "Datos actualizados";
        }
        public void Eliminar(int pos)
        {
            int CI = Buscar(pos);
            if (CI != -1)
            {
                dataPacientes.Eliminar(CI);
            }
        }

        public int Buscar(int pos)
        {
            return dataPacientes.Buscar(pos);
        }

        public int tamanio()
        {
            return dataPacientes.Tamanio();
        }

        public Paciente LtPaciente(int CI)
        {
            return dataPacientes.Elemento(CI);
        }
        public void crearVDG(DataGridView _with)
        {
            _with.Rows.Clear();
            _with.ColumnCount = 8;
            _with.Columns[0].HeaderText = "CI";
            _with.Columns[1].HeaderText = "Nombre";
            _with.Columns[2].HeaderText = "Edad";
            _with.Columns[3].HeaderText = "Diagnostico";
            _with.Columns[4].HeaderText = "Sexo";
            _with.Columns[5].HeaderText = "Discapacidad";
            _with.Columns[6].HeaderText = "Especialidad";
            _with.Columns[7].HeaderText = "Fecha cita";
        }
        public void mostrarPaciente(DataGridView _with,int i)
        {
            int f;
            f = _with.Rows.Add();
            _with.AutoResizeColumns();
            _with.Rows[f].Cells[0].Value = dataPacientes.Elemento(i).CI;
            _with.Rows[f].Cells[1].Value = dataPacientes.Elemento(i).Nombre;
            _with.Rows[f].Cells[2].Value = dataPacientes.Elemento(i).Edad;
            _with.Rows[f].Cells[3].Value = dataPacientes.Elemento(i).Diagnostico;
            _with.Rows[f].Cells[4].Value = dataPacientes.Elemento(i).Sexo;
            _with.Rows[f].Cells[5].Value = dataPacientes.Elemento(i).Discapacidad;
            _with.Rows[f].Cells[6].Value = dataPacientes.Elemento(i).Especialidad;
            _with.Rows[f].Cells[7].Value = dataPacientes.Elemento(i).FechaCita;
        }
        
        public void Cargar(DataGridView data) 
        {
            dataPacientes.cargarArchivo();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < tamanio(); i++)
            {
                mostrarPaciente(_with,i);
            }
        }
        public void CargarCI(DataGridView data,int CI)
        {
            dataPacientes.cargarArchivo();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).CI == CI)
                {
                    mostrarPaciente(_with, i);
                }
            }
        }
        public void Cargar_Nombre(DataGridView data, string Nombre)
        {
            dataPacientes.cargarArchivo();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).Nombre == Nombre)
                {
                    mostrarPaciente(_with, i);
                }
            }
        }
        public void Cargar_FechaCita(DataGridView data,string FechaCita)
        {
            dataPacientes.cargarArchivo();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).FechaCita == FechaCita)
                {
                    mostrarPaciente(_with, i);
                }
            }
        }
    }
}

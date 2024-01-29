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

        //Funcion para guardar un nuevo paciente
        public void guardar()
        {
            dataPacientes.guardar();
        }
        public void cargar()
        {
            dataPacientes.cargar();
        }
        public void guardar_Temp(Paciente datoP)
        {
            dataPacientes.guardar_temp(datoP);
        }
        //Funcion para actualizar un nuevo paciente utilizando su cedula
        public void Actualizar(int pos,Paciente datoP)
        {
            dataPacientes.actualizar(datoP,pos);
        }
        //Procedimiento para eliminar un paciente utilizando su cedula
        public void Eliminar(int pos)
        {
            int CI = Buscar(pos);
            if (CI != -1)
            {
                dataPacientes.Eliminar(CI);
            }
        }
        //Funcion para buscar un paciente utilizando su cedula y retornar su posicion
        public int Buscar(int pos)
        {
            return dataPacientes.Buscar(pos);
        }
        //Funcion para saber el tamaño de la lista de pacientes
        public int Tamanio()
        {
            return dataPacientes.Tamanio();
        }
        //Funcion para buscar la cantidad de discapacitados
        public int cant_Discapacitados()
        {
            return dataPacientes.cant_Discapacitados();
        }
        //funcion para buscar la cantidad de pacientes masculinos
        public int cant_Masculinos()
        {
            return dataPacientes.cant_Masculinos();
        }
        //funcion para buscar la cantidad de pacientes femeninas
        public int cant_Femeninas()
        {
            return dataPacientes.cant_Femeninas();
        }
        //Funcion para retornar los datos de un paciente en el lote
        public Paciente LtPaciente(int CI)
        {
            return dataPacientes.Elemento(CI);
        }
        //Procedimiento para crear las columnas del DataGridView
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
        //Procedimiento para agregar las filas en el DataGridView
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
        public void Cargar_datos()
        {
            dataPacientes.cargar();
        }
        //Procedimiento para hacer la carga normal del DataGridView
        public void Cargar_temp(DataGridView data) 
        {
            dataPacientes.cargarArchivo_temp();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < Tamanio(); i++)
            {
                mostrarPaciente(_with,i);
            }
            _with.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        //Procedimiento para hacer la carga del DataGridView en base a la Cedula
        public void CargarCI(DataGridView data,int CI)
        {
            dataPacientes.cargarArchivo_temp();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < Tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).CI == CI)
                {
                    mostrarPaciente(_with, i);
                }
            }
            _with.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        //Procedimiento para hacer la carga del DataGridView en base al Nombre
        public void Cargar_Nombre(DataGridView data, string Nombre)
        {
            dataPacientes.cargarArchivo_temp();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < Tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).Nombre == Nombre)
                {
                    mostrarPaciente(_with, i);
                }
            }
            _with.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
        //Procedimiento para hacer la carga del DataGridView en base a la Fecha de Cita
        public void Cargar_FechaCita(DataGridView data,string FechaCita)
        {
            dataPacientes.cargarArchivo_temp();
            var _with = data;
            crearVDG(_with);

            for (int i = 0; i < Tamanio(); i++)
            {
                if (dataPacientes.Elemento(i).FechaCita == FechaCita)
                {
                    mostrarPaciente(_with, i);
                }
            }
            _with.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }
    }
}

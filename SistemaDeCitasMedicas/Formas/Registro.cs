using SistemaDeCitasMedicas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCitasMedicas.Formas
{
    public partial class Registro : Form
    {
        Citas Citas = new Citas();
        int valor;
        public Registro()
        {
            InitializeComponent();
            DataTime_FechaCita.MinDate = DateTime.Today;
            Citas.Cargar(DGV_pacientes);
        }
        public bool vef_Vacio()
        {
            TextBox[] textBoxes = { textBox_CI, textBox_Diagnostico, textBox_Especialidad, textBox_Nombre };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text == "") return true;
            }
            if (comboBox_Discapacidad.Text == "" || comboBox_Sexo.Text == "" || Numerico_Edad.Value <= 0)
            {
                return true;
            }

            return false;
        }
        public void Error(string Error)
        {
            MessageBox.Show(Error, "Error", MessageBoxButtons.OK);
        }
        public void permitir(bool op)
        {
            TextBox[] textBoxes = { textBox_CI, textBox_Diagnostico, textBox_Especialidad, textBox_Nombre };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = op;
            }
            comboBox_Discapacidad.Enabled = op;
            comboBox_Sexo.Enabled = op;
            Numerico_Edad.Enabled = op;
        }
        public void limpiar()
        {
            TextBox[] textBoxes = { textBox_CI, textBox_Diagnostico, textBox_Especialidad, textBox_Nombre };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = "";
            }
            comboBox_Discapacidad.SelectedIndex = -1;
            comboBox_Sexo.SelectedIndex = -1;
            DataTime_FechaCita.Value = DateTime.Today;
            Numerico_Edad.Value = 0;
        }
        public void reestablecer()
        {
            limpiar();
            btn_Agregar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int pos = Citas.Buscar(Convert.ToInt32(textBox_CI.Text));
            if (pos == -1)
            {
                if (vef_Vacio())
                {
                    Error("Rellene algún campo faltante");
                    return;
                }
                Paciente paciente = new Paciente();
                paciente.CI = Convert.ToInt32(textBox_CI.Text.Trim());
                paciente.Nombre = textBox_Nombre.Text;
                paciente.Edad = Convert.ToInt32(Numerico_Edad.Value);
                paciente.Diagnostico = textBox_Diagnostico.Text;
                paciente.Sexo = comboBox_Sexo.Text;
                paciente.Discapacidad = comboBox_Discapacidad.Text;
                paciente.Especialidad = textBox_Especialidad.Text;
                paciente.FechaCita = DataTime_FechaCita.Text;
                reestablecer();
                Citas.guardar(paciente);
                Citas.Cargar(DGV_pacientes);
            }
            else Error("El usuario ya existe");
        }

        public void pintar_editar(int pos)
        {
            textBox_CI.Text = Citas.LtPaciente(pos).CI.ToString();
            textBox_Nombre.Text = Citas.LtPaciente(pos).Nombre.ToString();
            Numerico_Edad.Value = Citas.LtPaciente(pos).Edad;
            textBox_Diagnostico.Text = Citas.LtPaciente(pos).Diagnostico.ToString();
            comboBox_Sexo.Text = Citas.LtPaciente(pos).Sexo.ToString();
            comboBox_Discapacidad.Text = Citas.LtPaciente(pos).Discapacidad.ToString();
            textBox_Especialidad.Text = Citas.LtPaciente(pos).Especialidad.ToString();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int pos = Citas.Buscar(Convert.ToInt32(textBox_CI.Text));
            if (pos == valor || pos == -1)
            {
                if (vef_Vacio())
                {
                    Error("Rellene algún campo faltante");
                    return;
                }
                Paciente paciente = new Paciente();
                paciente.CI = Convert.ToInt32(textBox_CI.Text.Trim());
                paciente.Nombre = textBox_Nombre.Text;
                paciente.Edad = Convert.ToInt32(Numerico_Edad.Value);
                paciente.Diagnostico = textBox_Diagnostico.Text;
                paciente.Sexo = comboBox_Sexo.Text;
                paciente.Discapacidad = comboBox_Discapacidad.Text;
                paciente.Especialidad = textBox_Especialidad.Text;
                paciente.FechaCita = DataTime_FechaCita.Text;
                Citas.Actualizar(valor, paciente);
                Citas.Cargar(DGV_pacientes);
                reestablecer();
            }
            else Error("El usuario ya existe");
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(textBox_CI.Text);
            if (pos == -1)
            {
                Error("El usuario no esta registrado");
                return;
            }
            reestablecer();
            Citas.Eliminar(pos);
            Citas.Cargar(DGV_pacientes);
        }

        private void DGV_pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DGV_pacientes.ClearSelection();

            if (indice >= 0)
            {
                pintar_editar(indice);
                valor = indice;
                btn_Agregar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_Cancelar.Enabled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            reestablecer();
        }

        private void verificarChar(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

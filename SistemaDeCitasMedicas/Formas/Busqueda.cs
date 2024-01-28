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
    public partial class Busqueda : Form
    {
        Citas Citas = new Citas();
        int pos;
        public Busqueda()
        {
            InitializeComponent();
            dataTime_FechaCita.MinDate = DateTime.Today;
            Citas.Cargar(DGV_pacientes);
        }

        public void Error(string Error)
        {
            MessageBox.Show(Error, "Error", MessageBoxButtons.OK);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pos = comboBox_filtro.SelectedIndex;
            switch (pos)
            {
                case 0:
                    textBox_CI.Enabled = true;
                    textBox_Nombre.Enabled = false;
                    dataTime_FechaCita.Enabled = false;
                    break;
                case 1:
                    textBox_CI.Enabled = false;
                    textBox_Nombre.Enabled = true;
                    dataTime_FechaCita.Enabled = false;
                    break;
                case 2:
                    textBox_CI.Enabled = false;
                    textBox_Nombre.Enabled = false;
                    dataTime_FechaCita.Enabled = true;
                    break;
                default:
                    break;
            }
            btn_buscar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            switch (pos)
            {
                case 0:
                    int CI;
                    bool esNumero = int.TryParse(textBox_CI.Text, out CI);
                    if (esNumero) Citas.CargarCI(DGV_pacientes,CI);
                    else
                    {
                        Error("Es solo admitido números en este campo");
                        pos = -1;
                    }
                    break;
                case 1:
                    Citas.Cargar_Nombre(DGV_pacientes,textBox_Nombre.Text);
                    break;
                case 2:
                    Citas.Cargar_FechaCita(DGV_pacientes,dataTime_FechaCita.Text);
                    break;
            }
            if (pos >= 0)
            {
                textBox_CI.Text = "";
                textBox_Nombre.Text = "";
                dataTime_FechaCita.Value = DateTime.Today;
                textBox_CI.Enabled = false;
                textBox_Nombre.Enabled = false;
                dataTime_FechaCita.Enabled = false;
                btn_buscar.Enabled = false;
            }
        }
    }
}

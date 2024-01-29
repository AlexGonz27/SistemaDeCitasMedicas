using SistemaDeCitasMedicas.Formas;
using SistemaDeCitasMedicas.Clases;

namespace SistemaDeCitasMedicas
{
    public partial class Menu : Form
    {

        Citas citas = new Citas();
        public Menu()
        {
            InitializeComponent();
            abrirForma(new Inicio());
            citas.Cargar_datos();
        }
        //Boton para abrir paneles en general
        void abrirForma(Form FormHijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.Clear();
            }
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(FormHijo);
            this.panel_Contenedor.Tag = FormHijo;
            FormHijo.Show();
        }
        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            abrirForma(new Inicio());
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            abrirForma(new Registro());
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            abrirForma(new Busqueda());
        }

        private void GuardarDatos(object sender, FormClosingEventArgs e)
        {
            citas.guardar();
        }
    }
}

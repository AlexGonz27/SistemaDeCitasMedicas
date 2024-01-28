namespace SistemaDeCitasMedicas
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Inicio = new Button();
            panel_Bar = new Panel();
            btn_Buscar = new Button();
            btn_Registrar = new Button();
            panel1 = new Panel();
            picture_Logo = new PictureBox();
            panel_Contenedor = new Panel();
            panel_Bar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Logo).BeginInit();
            SuspendLayout();
            // 
            // btn_Inicio
            // 
            btn_Inicio.BackColor = SystemColors.Control;
            btn_Inicio.FlatStyle = FlatStyle.Flat;
            btn_Inicio.Location = new Point(30, 113);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(106, 36);
            btn_Inicio.TabIndex = 0;
            btn_Inicio.Text = "Inicio";
            btn_Inicio.UseVisualStyleBackColor = false;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // panel_Bar
            // 
            panel_Bar.BackColor = SystemColors.ScrollBar;
            panel_Bar.Controls.Add(btn_Buscar);
            panel_Bar.Controls.Add(btn_Registrar);
            panel_Bar.Controls.Add(panel1);
            panel_Bar.Controls.Add(btn_Inicio);
            panel_Bar.Dock = DockStyle.Left;
            panel_Bar.Location = new Point(0, 0);
            panel_Bar.Name = "panel_Bar";
            panel_Bar.Size = new Size(167, 561);
            panel_Bar.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = SystemColors.Control;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Location = new Point(30, 197);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(106, 36);
            btn_Buscar.TabIndex = 2;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = SystemColors.Control;
            btn_Registrar.FlatStyle = FlatStyle.Flat;
            btn_Registrar.Location = new Point(30, 155);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(106, 36);
            btn_Registrar.TabIndex = 1;
            btn_Registrar.Text = "Registrar";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(picture_Logo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 107);
            panel1.TabIndex = 0;
            // 
            // picture_Logo
            // 
            picture_Logo.Dock = DockStyle.Fill;
            picture_Logo.Image = Properties.Resources.image_removebg_preview__6_;
            picture_Logo.Location = new Point(0, 0);
            picture_Logo.Name = "picture_Logo";
            picture_Logo.Size = new Size(167, 107);
            picture_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Logo.TabIndex = 0;
            picture_Logo.TabStop = false;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(167, 0);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(617, 561);
            panel_Contenedor.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel_Contenedor);
            Controls.Add(panel_Bar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            Text = "Sistema Citas de GALA";
            panel_Bar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Inicio;
        private Button button2;
        private Button Inicio;
        private Panel panel_Bar;
        private Button btn_Buscar;
        private Button btn_Registrar;
        private Panel panel1;
        private Panel panel_Contenedor;
        private PictureBox picture_Logo;
    }
}

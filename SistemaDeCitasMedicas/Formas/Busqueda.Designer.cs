namespace SistemaDeCitasMedicas.Formas
{
    partial class Busqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fontDialog1 = new FontDialog();
            DGV_pacientes = new DataGridView();
            label1 = new Label();
            textBox_CI = new TextBox();
            comboBox_filtro = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox_Nombre = new TextBox();
            label4 = new Label();
            dataTime_FechaCita = new DateTimePicker();
            btn_buscar = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label_cantFemeninas = new Label();
            label_cantMasculinos = new Label();
            label_CantDiscapacitados = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btn_recargar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_pacientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_pacientes
            // 
            DGV_pacientes.AllowUserToAddRows = false;
            DGV_pacientes.AllowUserToDeleteRows = false;
            DGV_pacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_pacientes.Location = new Point(24, 242);
            DGV_pacientes.Name = "DGV_pacientes";
            DGV_pacientes.ReadOnly = true;
            DGV_pacientes.Size = new Size(570, 307);
            DGV_pacientes.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 25;
            label1.Text = "Buscar por";
            // 
            // textBox_CI
            // 
            textBox_CI.Enabled = false;
            textBox_CI.Location = new Point(108, 92);
            textBox_CI.MaxLength = 8;
            textBox_CI.Name = "textBox_CI";
            textBox_CI.Size = new Size(100, 23);
            textBox_CI.TabIndex = 26;
            textBox_CI.KeyPress += verificarChar;
            // 
            // comboBox_filtro
            // 
            comboBox_filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_filtro.FormattingEnabled = true;
            comboBox_filtro.Items.AddRange(new object[] { "CI", "Nombre", "Fecha de Cita" });
            comboBox_filtro.Location = new Point(24, 38);
            comboBox_filtro.Name = "comboBox_filtro";
            comboBox_filtro.Size = new Size(121, 23);
            comboBox_filtro.TabIndex = 24;
            comboBox_filtro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 27;
            label2.Text = "C.I";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 28;
            label3.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Enabled = false;
            textBox_Nombre.Location = new Point(108, 121);
            textBox_Nombre.MaxLength = 25;
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(176, 23);
            textBox_Nombre.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 153);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 30;
            label4.Text = "Fecha de Cita";
            // 
            // dataTime_FechaCita
            // 
            dataTime_FechaCita.Enabled = false;
            dataTime_FechaCita.Format = DateTimePickerFormat.Short;
            dataTime_FechaCita.Location = new Point(108, 150);
            dataTime_FechaCita.MinDate = new DateTime(2024, 1, 28, 0, 0, 0, 0);
            dataTime_FechaCita.Name = "dataTime_FechaCita";
            dataTime_FechaCita.Size = new Size(100, 23);
            dataTime_FechaCita.TabIndex = 31;
            // 
            // btn_buscar
            // 
            btn_buscar.Enabled = false;
            btn_buscar.Location = new Point(24, 185);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(92, 37);
            btn_buscar.TabIndex = 32;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label_cantFemeninas);
            panel1.Controls.Add(label_cantMasculinos);
            panel1.Controls.Add(label_CantDiscapacitados);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(389, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 148);
            panel1.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label8.Location = new Point(15, 17);
            label8.Name = "label8";
            label8.Size = new Size(158, 14);
            label8.TabIndex = 6;
            label8.Text = "Cantidad de Pacientes:";
            // 
            // label_cantFemeninas
            // 
            label_cantFemeninas.AutoSize = true;
            label_cantFemeninas.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label_cantFemeninas.Location = new Point(149, 104);
            label_cantFemeninas.Name = "label_cantFemeninas";
            label_cantFemeninas.Size = new Size(0, 14);
            label_cantFemeninas.TabIndex = 5;
            // 
            // label_cantMasculinos
            // 
            label_cantMasculinos.AutoSize = true;
            label_cantMasculinos.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label_cantMasculinos.Location = new Point(150, 75);
            label_cantMasculinos.Name = "label_cantMasculinos";
            label_cantMasculinos.Size = new Size(0, 14);
            label_cantMasculinos.TabIndex = 4;
            // 
            // label_CantDiscapacitados
            // 
            label_CantDiscapacitados.AutoSize = true;
            label_CantDiscapacitados.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label_CantDiscapacitados.Location = new Point(149, 46);
            label_CantDiscapacitados.Name = "label_CantDiscapacitados";
            label_CantDiscapacitados.Size = new Size(0, 14);
            label_CantDiscapacitados.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label7.Location = new Point(15, 109);
            label7.Name = "label7";
            label7.Size = new Size(128, 14);
            label7.TabIndex = 2;
            label7.Text = "Femeninas - - - ->";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 75);
            label6.Name = "label6";
            label6.Size = new Size(129, 14);
            label6.TabIndex = 1;
            label6.Text = "Masculinos - - - ->";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 46);
            label5.Name = "label5";
            label5.Size = new Size(130, 14);
            label5.TabIndex = 0;
            label5.Text = "Discapacitados  ->";
            // 
            // btn_recargar
            // 
            btn_recargar.Location = new Point(122, 185);
            btn_recargar.Name = "btn_recargar";
            btn_recargar.Size = new Size(92, 37);
            btn_recargar.TabIndex = 34;
            btn_recargar.Text = "Recargar";
            btn_recargar.UseVisualStyleBackColor = true;
            btn_recargar.Click += btn_recargar_Click;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 561);
            Controls.Add(btn_recargar);
            Controls.Add(panel1);
            Controls.Add(btn_buscar);
            Controls.Add(dataTime_FechaCita);
            Controls.Add(label4);
            Controls.Add(textBox_Nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_CI);
            Controls.Add(label1);
            Controls.Add(comboBox_filtro);
            Controls.Add(DGV_pacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Busqueda";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)DGV_pacientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private DataGridView DGV_pacientes;
        private Label label1;
        private TextBox textBox_CI;
        private ComboBox comboBox_filtro;
        private Label label2;
        private Label label3;
        private TextBox textBox_Nombre;
        private Label label4;
        private DateTimePicker dataTime_FechaCita;
        private Button btn_buscar;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label_cantFemeninas;
        private Label label_cantMasculinos;
        private Label label_CantDiscapacitados;
        private Button btn_recargar;
        private Label label8;
    }
}
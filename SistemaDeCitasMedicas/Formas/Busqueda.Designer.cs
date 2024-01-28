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
            ((System.ComponentModel.ISupportInitialize)DGV_pacientes).BeginInit();
            SuspendLayout();
            // 
            // DGV_pacientes
            // 
            DGV_pacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_pacientes.Location = new Point(24, 242);
            DGV_pacientes.Name = "DGV_pacientes";
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
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 32;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // Busqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 561);
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
    }
}
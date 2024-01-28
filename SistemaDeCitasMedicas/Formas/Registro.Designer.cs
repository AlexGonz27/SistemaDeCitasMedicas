﻿namespace SistemaDeCitasMedicas.Formas
{
    partial class Registro
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox_CI = new TextBox();
            comboBox_Sexo = new ComboBox();
            textBox_Nombre = new TextBox();
            textBox_Especialidad = new TextBox();
            btn_Agregar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            label_CI = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Numerico_Edad = new NumericUpDown();
            comboBox_Discapacidad = new ComboBox();
            DGV_pacientes = new DataGridView();
            btn_select = new Button();
            textBox_Diagnostico = new TextBox();
            DataTime_FechaCita = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)Numerico_Edad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_pacientes).BeginInit();
            SuspendLayout();
            // 
            // textBox_CI
            // 
            textBox_CI.Location = new Point(109, 59);
            textBox_CI.MaxLength = 8;
            textBox_CI.Name = "textBox_CI";
            textBox_CI.Size = new Size(100, 23);
            textBox_CI.TabIndex = 0;
            // 
            // comboBox_Sexo
            // 
            comboBox_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Sexo.FormattingEnabled = true;
            comboBox_Sexo.Items.AddRange(new object[] { "Masculino\t", "Femenino" });
            comboBox_Sexo.Location = new Point(108, 175);
            comboBox_Sexo.Name = "comboBox_Sexo";
            comboBox_Sexo.Size = new Size(101, 23);
            comboBox_Sexo.TabIndex = 1;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.AllowDrop = true;
            textBox_Nombre.Location = new Point(109, 88);
            textBox_Nombre.MaxLength = 25;
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(185, 23);
            textBox_Nombre.TabIndex = 2;
            // 
            // textBox_Especialidad
            // 
            textBox_Especialidad.Location = new Point(109, 233);
            textBox_Especialidad.Name = "textBox_Especialidad";
            textBox_Especialidad.Size = new Size(100, 23);
            textBox_Especialidad.TabIndex = 7;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(349, 125);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(90, 35);
            btn_Agregar.TabIndex = 8;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Enabled = false;
            btn_modificar.Location = new Point(349, 166);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(90, 35);
            btn_modificar.TabIndex = 9;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Enabled = false;
            btn_eliminar.Location = new Point(349, 207);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(90, 35);
            btn_eliminar.TabIndex = 10;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // label_CI
            // 
            label_CI.AutoSize = true;
            label_CI.Location = new Point(84, 62);
            label_CI.Name = "label_CI";
            label_CI.Size = new Size(18, 15);
            label_CI.TabIndex = 11;
            label_CI.Text = "CI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 236);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 13;
            label2.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 178);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 152);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 15;
            label4.Text = "Diagnostico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 207);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 16;
            label5.Text = "Discapacidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 120);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 17;
            label6.Text = "Edad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 265);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 18;
            label7.Text = "Fecha de Cita";
            // 
            // Numerico_Edad
            // 
            Numerico_Edad.Location = new Point(108, 117);
            Numerico_Edad.Name = "Numerico_Edad";
            Numerico_Edad.Size = new Size(46, 23);
            Numerico_Edad.TabIndex = 19;
            // 
            // comboBox_Discapacidad
            // 
            comboBox_Discapacidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Discapacidad.FormattingEnabled = true;
            comboBox_Discapacidad.Items.AddRange(new object[] { "Si", "No" });
            comboBox_Discapacidad.Location = new Point(108, 204);
            comboBox_Discapacidad.Name = "comboBox_Discapacidad";
            comboBox_Discapacidad.Size = new Size(46, 23);
            comboBox_Discapacidad.TabIndex = 20;
            // 
            // DGV_pacientes
            // 
            DGV_pacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_pacientes.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_pacientes.Location = new Point(24, 305);
            DGV_pacientes.Name = "DGV_pacientes";
            DGV_pacientes.Size = new Size(570, 244);
            DGV_pacientes.TabIndex = 22;
            // 
            // btn_select
            // 
            btn_select.Location = new Point(227, 59);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(67, 23);
            btn_select.TabIndex = 23;
            btn_select.Text = "Select";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // textBox_Diagnostico
            // 
            textBox_Diagnostico.Location = new Point(109, 149);
            textBox_Diagnostico.Name = "textBox_Diagnostico";
            textBox_Diagnostico.Size = new Size(100, 23);
            textBox_Diagnostico.TabIndex = 5;
            // 
            // DataTime_FechaCita
            // 
            DataTime_FechaCita.CustomFormat = " ";
            DataTime_FechaCita.Format = DateTimePickerFormat.Short;
            DataTime_FechaCita.ImeMode = ImeMode.On;
            DataTime_FechaCita.Location = new Point(109, 265);
            DataTime_FechaCita.MinDate = new DateTime(2024, 1, 27, 23, 14, 3, 0);
            DataTime_FechaCita.Name = "DataTime_FechaCita";
            DataTime_FechaCita.Size = new Size(100, 23);
            DataTime_FechaCita.TabIndex = 24;
            DataTime_FechaCita.Value = new DateTime(2024, 1, 27, 23, 14, 3, 0);
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 561);
            Controls.Add(DataTime_FechaCita);
            Controls.Add(btn_select);
            Controls.Add(DGV_pacientes);
            Controls.Add(comboBox_Discapacidad);
            Controls.Add(Numerico_Edad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_CI);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_Agregar);
            Controls.Add(textBox_Especialidad);
            Controls.Add(textBox_Diagnostico);
            Controls.Add(textBox_Nombre);
            Controls.Add(comboBox_Sexo);
            Controls.Add(textBox_CI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)Numerico_Edad).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_pacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_CI;
        private ComboBox comboBox_Sexo;
        private TextBox textBox_Nombre;
        private TextBox textBox3;
        private TextBox textBox_Discapacidad;
        private TextBox textBox_Especialidad;
        private Button btn_Agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Label label_CI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown Numerico_Edad;
        private ComboBox comboBox_Discapacidad;
        private DataGridView DGV_pacientes;
        private Button btn_select;
        private TextBox textBox_Diagnostico;
        private DateTimePicker DataTime_FechaCita;
    }
}
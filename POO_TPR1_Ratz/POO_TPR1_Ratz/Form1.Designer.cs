namespace POO_TPR1_Ratz
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.txt_Fecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_activo = new System.Windows.Forms.CheckBox();
            this.txt_Cant_Materias_Aprobadas = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Legajo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_edad_ingreso = new System.Windows.Forms.TextBox();
            this.txt_no_aprobadas = new System.Windows.Forms.TextBox();
            this.txt_antiguedad = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radio_dias = new System.Windows.Forms.RadioButton();
            this.radio_meses = new System.Windows.Forms.RadioButton();
            this.radio_años = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Alumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Fecha_Ingreso);
            this.groupBox2.Controls.Add(this.txt_Fecha_Nacimiento);
            this.groupBox2.Controls.Add(this.txt_activo);
            this.groupBox2.Controls.Add(this.txt_Cant_Materias_Aprobadas);
            this.groupBox2.Controls.Add(this.txt_Apellido);
            this.groupBox2.Controls.Add(this.txt_Nombre);
            this.groupBox2.Controls.Add(this.txt_Legajo);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(29, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(98, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(179, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Guardar Cambios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad de Materias Aprobadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Legajo";
            // 
            // txt_Fecha_Ingreso
            // 
            this.txt_Fecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Fecha_Ingreso.Location = new System.Drawing.Point(179, 124);
            this.txt_Fecha_Ingreso.Name = "txt_Fecha_Ingreso";
            this.txt_Fecha_Ingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha_Ingreso.TabIndex = 8;
            // 
            // txt_Fecha_Nacimiento
            // 
            this.txt_Fecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Fecha_Nacimiento.Location = new System.Drawing.Point(179, 98);
            this.txt_Fecha_Nacimiento.Name = "txt_Fecha_Nacimiento";
            this.txt_Fecha_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha_Nacimiento.TabIndex = 7;
            // 
            // txt_activo
            // 
            this.txt_activo.AutoSize = true;
            this.txt_activo.Location = new System.Drawing.Point(179, 150);
            this.txt_activo.Name = "txt_activo";
            this.txt_activo.Size = new System.Drawing.Size(56, 17);
            this.txt_activo.TabIndex = 10;
            this.txt_activo.Text = "Activo";
            this.txt_activo.UseVisualStyleBackColor = true;
            // 
            // txt_Cant_Materias_Aprobadas
            // 
            this.txt_Cant_Materias_Aprobadas.Location = new System.Drawing.Point(179, 173);
            this.txt_Cant_Materias_Aprobadas.Name = "txt_Cant_Materias_Aprobadas";
            this.txt_Cant_Materias_Aprobadas.Size = new System.Drawing.Size(56, 20);
            this.txt_Cant_Materias_Aprobadas.TabIndex = 11;
            this.txt_Cant_Materias_Aprobadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(179, 71);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 6;
            this.txt_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(179, 45);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Legajo
            // 
            this.txt_Legajo.Location = new System.Drawing.Point(179, 19);
            this.txt_Legajo.Name = "txt_Legajo";
            this.txt_Legajo.Size = new System.Drawing.Size(56, 20);
            this.txt_Legajo.TabIndex = 4;
            this.txt_Legajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar Alumno Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar Alumno Seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Agregar Nuevo Alumno";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(66, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Consultar Información Alumno";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_edad_ingreso);
            this.groupBox3.Controls.Add(this.txt_no_aprobadas);
            this.groupBox3.Controls.Add(this.txt_antiguedad);
            this.groupBox3.Location = new System.Drawing.Point(326, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Alumno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Edad de Ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Materias No Aprobadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Antigüedad";
            // 
            // txt_edad_ingreso
            // 
            this.txt_edad_ingreso.Location = new System.Drawing.Point(150, 81);
            this.txt_edad_ingreso.Name = "txt_edad_ingreso";
            this.txt_edad_ingreso.ReadOnly = true;
            this.txt_edad_ingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_edad_ingreso.TabIndex = 0;
            this.txt_edad_ingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_no_aprobadas
            // 
            this.txt_no_aprobadas.Location = new System.Drawing.Point(150, 55);
            this.txt_no_aprobadas.Name = "txt_no_aprobadas";
            this.txt_no_aprobadas.ReadOnly = true;
            this.txt_no_aprobadas.Size = new System.Drawing.Size(100, 20);
            this.txt_no_aprobadas.TabIndex = 0;
            this.txt_no_aprobadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_antiguedad
            // 
            this.txt_antiguedad.Location = new System.Drawing.Point(150, 29);
            this.txt_antiguedad.Name = "txt_antiguedad";
            this.txt_antiguedad.ReadOnly = true;
            this.txt_antiguedad.Size = new System.Drawing.Size(100, 20);
            this.txt_antiguedad.TabIndex = 0;
            this.txt_antiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_dias);
            this.groupBox4.Controls.Add(this.radio_meses);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.radio_años);
            this.groupBox4.Location = new System.Drawing.Point(326, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 91);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ver Antigüedad en...";
            // 
            // radio_dias
            // 
            this.radio_dias.AutoSize = true;
            this.radio_dias.Location = new System.Drawing.Point(124, 20);
            this.radio_dias.Name = "radio_dias";
            this.radio_dias.Size = new System.Drawing.Size(46, 17);
            this.radio_dias.TabIndex = 2;
            this.radio_dias.Text = "Dias";
            this.radio_dias.UseVisualStyleBackColor = true;
            // 
            // radio_meses
            // 
            this.radio_meses.AutoSize = true;
            this.radio_meses.Location = new System.Drawing.Point(62, 21);
            this.radio_meses.Name = "radio_meses";
            this.radio_meses.Size = new System.Drawing.Size(56, 17);
            this.radio_meses.TabIndex = 1;
            this.radio_meses.Text = "Meses";
            this.radio_meses.UseVisualStyleBackColor = true;
            // 
            // radio_años
            // 
            this.radio_años.AutoSize = true;
            this.radio_años.Checked = true;
            this.radio_años.Location = new System.Drawing.Point(7, 20);
            this.radio_años.Name = "radio_años";
            this.radio_años.Size = new System.Drawing.Size(49, 17);
            this.radio_años.TabIndex = 0;
            this.radio_años.TabStop = true;
            this.radio_años.Text = "Años";
            this.radio_años.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "POO TPR1 Pablo Ratz";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_Fecha_Ingreso;
        private System.Windows.Forms.DateTimePicker txt_Fecha_Nacimiento;
        private System.Windows.Forms.CheckBox txt_activo;
        private System.Windows.Forms.TextBox txt_Cant_Materias_Aprobadas;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Legajo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_edad_ingreso;
        private System.Windows.Forms.TextBox txt_no_aprobadas;
        private System.Windows.Forms.TextBox txt_antiguedad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radio_dias;
        private System.Windows.Forms.RadioButton radio_meses;
        private System.Windows.Forms.RadioButton radio_años;
    }
}


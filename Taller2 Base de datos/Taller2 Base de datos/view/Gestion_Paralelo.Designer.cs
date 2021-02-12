namespace Taller2_Base_de_datos.view
{
    partial class Gestion_Paralelo
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataParalelo = new System.Windows.Forms.DataGridView();
            this.codParaleloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonoResposabilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraleloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtTotalOficina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAlumnos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataAlumnosEn = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosEnParaleloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxParalelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtRutAlumnoEditarParalelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNewBono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizarProfesor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParaleloId = new System.Windows.Forms.TextBox();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataParalelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraleloBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnosEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosEnParaleloBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Paralelo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Estudiante a un paralelo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataParalelo
            // 
            this.dataParalelo.AllowUserToAddRows = false;
            this.dataParalelo.AllowUserToDeleteRows = false;
            this.dataParalelo.AllowUserToOrderColumns = true;
            this.dataParalelo.AutoGenerateColumns = false;
            this.dataParalelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataParalelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codParaleloDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.nombreProfesorDataGridViewTextBoxColumn,
            this.bonoResposabilidadDataGridViewTextBoxColumn,
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn,
            this.rutProfesorDataGridViewTextBoxColumn,
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn});
            this.dataParalelo.DataSource = this.paraleloBindingSource;
            this.dataParalelo.Location = new System.Drawing.Point(6, 23);
            this.dataParalelo.Name = "dataParalelo";
            this.dataParalelo.ReadOnly = true;
            this.dataParalelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataParalelo.Size = new System.Drawing.Size(544, 305);
            this.dataParalelo.TabIndex = 2;
            // 
            // codParaleloDataGridViewTextBoxColumn
            // 
            this.codParaleloDataGridViewTextBoxColumn.DataPropertyName = "CodParalelo";
            this.codParaleloDataGridViewTextBoxColumn.HeaderText = "CodParalelo";
            this.codParaleloDataGridViewTextBoxColumn.Name = "codParaleloDataGridViewTextBoxColumn";
            this.codParaleloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "NombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "NombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProfesorDataGridViewTextBoxColumn
            // 
            this.nombreProfesorDataGridViewTextBoxColumn.DataPropertyName = "NombreProfesor";
            this.nombreProfesorDataGridViewTextBoxColumn.HeaderText = "NombreProfesor";
            this.nombreProfesorDataGridViewTextBoxColumn.Name = "nombreProfesorDataGridViewTextBoxColumn";
            this.nombreProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonoResposabilidadDataGridViewTextBoxColumn
            // 
            this.bonoResposabilidadDataGridViewTextBoxColumn.DataPropertyName = "BonoResposabilidad";
            this.bonoResposabilidadDataGridViewTextBoxColumn.HeaderText = "BonoResposabilidad";
            this.bonoResposabilidadDataGridViewTextBoxColumn.Name = "bonoResposabilidadDataGridViewTextBoxColumn";
            this.bonoResposabilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEstudianteEncargadoDataGridViewTextBoxColumn
            // 
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEstudianteEncargado";
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn.HeaderText = "NombreEstudianteEncargado";
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn.Name = "nombreEstudianteEncargadoDataGridViewTextBoxColumn";
            this.nombreEstudianteEncargadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutProfesorDataGridViewTextBoxColumn
            // 
            this.rutProfesorDataGridViewTextBoxColumn.DataPropertyName = "RutProfesor";
            this.rutProfesorDataGridViewTextBoxColumn.HeaderText = "RutProfesor";
            this.rutProfesorDataGridViewTextBoxColumn.Name = "rutProfesorDataGridViewTextBoxColumn";
            this.rutProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            this.rutProfesorDataGridViewTextBoxColumn.Visible = false;
            // 
            // rutEstudianteEncargadoDataGridViewTextBoxColumn
            // 
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn.DataPropertyName = "RutEstudianteEncargado";
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn.HeaderText = "RutEstudianteEncargado";
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn.Name = "rutEstudianteEncargadoDataGridViewTextBoxColumn";
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.rutEstudianteEncargadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // paraleloBindingSource
            // 
            this.paraleloBindingSource.DataSource = typeof(Taller2_Base_de_datos.view.Paralelos.Paralelo);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar Alumno del paralelo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar el paralelo de un alumno";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Eliminar un Paralelo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(364, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 39);
            this.button7.TabIndex = 7;
            this.button7.Text = "Agregar Estudiante Coordinador";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataParalelo);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.btnVerAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 379);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARALELOS AGREGADOS";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(111, 334);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 39);
            this.button9.TabIndex = 14;
            this.button9.Text = "Editar Profesor";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(6, 334);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(99, 39);
            this.btnVerAlumnos.TabIndex = 10;
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtTotalOficina);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalAlumnos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dataAlumnosEn);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(577, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 379);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALUMNOS EN EL PARALELO";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "Ver Alumnos inscritos en horario de oficina";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTotalOficina
            // 
            this.txtTotalOficina.Location = new System.Drawing.Point(189, 293);
            this.txtTotalOficina.Name = "txtTotalOficina";
            this.txtTotalOficina.ReadOnly = true;
            this.txtTotalOficina.Size = new System.Drawing.Size(160, 20);
            this.txtTotalOficina.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total de Alumnos que se inscribieron \r\nen horario de oficina:";
            // 
            // txtTotalAlumnos
            // 
            this.txtTotalAlumnos.Location = new System.Drawing.Point(80, 260);
            this.txtTotalAlumnos.Name = "txtTotalAlumnos";
            this.txtTotalAlumnos.ReadOnly = true;
            this.txtTotalAlumnos.Size = new System.Drawing.Size(269, 20);
            this.txtTotalAlumnos.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Alumnos:";
            // 
            // dataAlumnosEn
            // 
            this.dataAlumnosEn.AllowUserToAddRows = false;
            this.dataAlumnosEn.AllowUserToDeleteRows = false;
            this.dataAlumnosEn.AllowUserToOrderColumns = true;
            this.dataAlumnosEn.AutoGenerateColumns = false;
            this.dataAlumnosEn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlumnosEn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreAlumnoDataGridViewTextBoxColumn,
            this.fecharegistroDataGridViewTextBoxColumn});
            this.dataAlumnosEn.DataSource = this.alumnosEnParaleloBindingSource;
            this.dataAlumnosEn.Location = new System.Drawing.Point(6, 23);
            this.dataAlumnosEn.Name = "dataAlumnosEn";
            this.dataAlumnosEn.ReadOnly = true;
            this.dataAlumnosEn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlumnosEn.Size = new System.Drawing.Size(349, 230);
            this.dataAlumnosEn.TabIndex = 0;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "Rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "Rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreAlumnoDataGridViewTextBoxColumn
            // 
            this.nombreAlumnoDataGridViewTextBoxColumn.DataPropertyName = "NombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.HeaderText = "NombreAlumno";
            this.nombreAlumnoDataGridViewTextBoxColumn.Name = "nombreAlumnoDataGridViewTextBoxColumn";
            this.nombreAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "Fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            this.fecharegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnosEnParaleloBindingSource
            // 
            this.alumnosEnParaleloBindingSource.DataSource = typeof(Taller2_Base_de_datos.view.Paralelos.AlumnosEnParalelo);
            // 
            // cboxParalelos
            // 
            this.cboxParalelos.FormattingEnabled = true;
            this.cboxParalelos.Location = new System.Drawing.Point(9, 102);
            this.cboxParalelos.Name = "cboxParalelos";
            this.cboxParalelos.Size = new System.Drawing.Size(146, 21);
            this.cboxParalelos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecciona El paralelo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRutAlumnoEditarParalelo);
            this.groupBox3.Controls.Add(this.cboxParalelos);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(941, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 172);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar el paralelo de alumno";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 143);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Actualizar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtRutAlumnoEditarParalelo
            // 
            this.txtRutAlumnoEditarParalelo.Location = new System.Drawing.Point(9, 53);
            this.txtRutAlumnoEditarParalelo.Name = "txtRutAlumnoEditarParalelo";
            this.txtRutAlumnoEditarParalelo.ReadOnly = true;
            this.txtRutAlumnoEditarParalelo.Size = new System.Drawing.Size(146, 20);
            this.txtRutAlumnoEditarParalelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rut Alumno";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNewBono);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnActualizarProfesor);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtParaleloId);
            this.groupBox4.Controls.Add(this.cbxProfesor);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(941, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 194);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actualizar el Profesor de un Paralelo";
            // 
            // txtNewBono
            // 
            this.txtNewBono.Location = new System.Drawing.Point(9, 122);
            this.txtNewBono.Name = "txtNewBono";
            this.txtNewBono.Size = new System.Drawing.Size(145, 20);
            this.txtNewBono.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nuevo Bono Responsabilidad:";
            // 
            // btnActualizarProfesor
            // 
            this.btnActualizarProfesor.Location = new System.Drawing.Point(82, 157);
            this.btnActualizarProfesor.Name = "btnActualizarProfesor";
            this.btnActualizarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarProfesor.TabIndex = 13;
            this.btnActualizarProfesor.Text = "Actualizar";
            this.btnActualizarProfesor.UseVisualStyleBackColor = true;
            this.btnActualizarProfesor.Click += new System.EventHandler(this.btnActualizarProfesor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecciona Profesor:";
            // 
            // txtParaleloId
            // 
            this.txtParaleloId.Location = new System.Drawing.Point(8, 42);
            this.txtParaleloId.Name = "txtParaleloId";
            this.txtParaleloId.ReadOnly = true;
            this.txtParaleloId.Size = new System.Drawing.Size(146, 20);
            this.txtParaleloId.TabIndex = 1;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(8, 82);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(146, 21);
            this.cbxProfesor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo Paralelo";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(969, 430);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 39);
            this.button10.TabIndex = 16;
            this.button10.Text = "Limpiar Filtros";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Gestion_Paralelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 499);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Gestion_Paralelo";
            this.Text = "Gestion_Paralelo";
            this.Activated += new System.EventHandler(this.Gestion_Paralelo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataParalelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paraleloBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnosEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosEnParaleloBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataParalelo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataAlumnosEn;
        private System.Windows.Forms.Button btnVerAlumnos;
        private System.Windows.Forms.ComboBox cboxParalelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtRutAlumnoEditarParalelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizarProfesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParaleloId;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewBono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codParaleloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonoResposabilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEstudianteEncargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutEstudianteEncargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paraleloBindingSource;
        private System.Windows.Forms.TextBox txtTotalAlumnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalOficina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnosEnParaleloBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
    }
}
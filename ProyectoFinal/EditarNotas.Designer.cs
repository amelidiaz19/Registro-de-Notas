namespace ProyectoFinal
{
    partial class EditarNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarNotas));
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotas = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnAgregarNotas = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IconExit = new System.Windows.Forms.PictureBox();
            this.IconMin = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtExamen2 = new System.Windows.Forms.TextBox();
            this.txtExamen1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.curso,
            this.apaterno,
            this.amaterno,
            this.nombre,
            this.seccion,
            this.turno,
            this.docente,
            this.ex1,
            this.ex2,
            this.parcial,
            this.final,
            this.promedio});
            this.dataGridViewNotas.Location = new System.Drawing.Point(12, 416);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.ReadOnly = true;
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.Size = new System.Drawing.Size(1475, 405);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNotas_CellMouseClick);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.MinimumWidth = 6;
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 125;
            // 
            // apaterno
            // 
            this.apaterno.HeaderText = "A. Paterno";
            this.apaterno.MinimumWidth = 6;
            this.apaterno.Name = "apaterno";
            this.apaterno.ReadOnly = true;
            this.apaterno.Width = 125;
            // 
            // amaterno
            // 
            this.amaterno.HeaderText = "A. Materno";
            this.amaterno.MinimumWidth = 6;
            this.amaterno.Name = "amaterno";
            this.amaterno.ReadOnly = true;
            this.amaterno.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // seccion
            // 
            this.seccion.HeaderText = "Sección";
            this.seccion.MinimumWidth = 6;
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            this.seccion.Width = 125;
            // 
            // turno
            // 
            this.turno.HeaderText = "Turno";
            this.turno.MinimumWidth = 6;
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 125;
            // 
            // docente
            // 
            this.docente.HeaderText = "Docente";
            this.docente.MinimumWidth = 6;
            this.docente.Name = "docente";
            this.docente.ReadOnly = true;
            this.docente.Width = 125;
            // 
            // ex1
            // 
            this.ex1.HeaderText = "Examen 1";
            this.ex1.MinimumWidth = 6;
            this.ex1.Name = "ex1";
            this.ex1.ReadOnly = true;
            this.ex1.Width = 125;
            // 
            // ex2
            // 
            this.ex2.HeaderText = "Examen 2";
            this.ex2.MinimumWidth = 6;
            this.ex2.Name = "ex2";
            this.ex2.ReadOnly = true;
            this.ex2.Width = 125;
            // 
            // parcial
            // 
            this.parcial.HeaderText = "Parcial";
            this.parcial.MinimumWidth = 6;
            this.parcial.Name = "parcial";
            this.parcial.ReadOnly = true;
            this.parcial.Width = 125;
            // 
            // final
            // 
            this.final.HeaderText = "Final";
            this.final.MinimumWidth = 6;
            this.final.Name = "final";
            this.final.ReadOnly = true;
            this.final.Width = 125;
            // 
            // promedio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.promedio.DefaultCellStyle = dataGridViewCellStyle1;
            this.promedio.HeaderText = "Promedio";
            this.promedio.MinimumWidth = 6;
            this.promedio.Name = "promedio";
            this.promedio.ReadOnly = true;
            this.promedio.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1095, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 134;
            this.label2.Text = "Filtros";
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente",
            "Sumar Notas"});
            this.cbOrdenar.Location = new System.Drawing.Point(1100, 67);
            this.cbOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(216, 35);
            this.cbOrdenar.TabIndex = 135;
            this.cbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cbOrdenar_SelectedIndexChanged);
            this.cbOrdenar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOrdenar_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(1318, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 73);
            this.panel2.TabIndex = 133;
            // 
            // btnAplicar
            // 
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(1100, 119);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(231, 73);
            this.btnAplicar.TabIndex = 132;
            this.btnAplicar.Text = "Aplicar Filtro";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(1473, 329);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 73);
            this.panel1.TabIndex = 131;
            // 
            // btnNotas
            // 
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(1252, 329);
            this.btnNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(235, 73);
            this.btnNotas.TabIndex = 130;
            this.btnNotas.Text = "Ver Registro";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel15.Location = new System.Drawing.Point(496, 329);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(13, 73);
            this.panel15.TabIndex = 127;
            // 
            // btnAgregarNotas
            // 
            this.btnAgregarNotas.FlatAppearance.BorderSize = 0;
            this.btnAgregarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnAgregarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNotas.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNotas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNotas.Location = new System.Drawing.Point(275, 329);
            this.btnAgregarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNotas.Name = "btnAgregarNotas";
            this.btnAgregarNotas.Size = new System.Drawing.Size(235, 73);
            this.btnAgregarNotas.TabIndex = 126;
            this.btnAgregarNotas.Text = "Agregar Nota";
            this.btnAgregarNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarNotas.UseVisualStyleBackColor = true;
            this.btnAgregarNotas.Click += new System.EventHandler(this.btnAgregarNotas_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IconExit
            // 
            this.IconExit.Image = ((System.Drawing.Image)(resources.GetObject("IconExit.Image")));
            this.IconExit.Location = new System.Drawing.Point(1443, 12);
            this.IconExit.Name = "IconExit";
            this.IconExit.Size = new System.Drawing.Size(44, 51);
            this.IconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconExit.TabIndex = 140;
            this.IconExit.TabStop = false;
            this.IconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // IconMin
            // 
            this.IconMin.Image = ((System.Drawing.Image)(resources.GetObject("IconMin.Image")));
            this.IconMin.Location = new System.Drawing.Point(1393, 12);
            this.IconMin.Name = "IconMin";
            this.IconMin.Size = new System.Drawing.Size(44, 51);
            this.IconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMin.TabIndex = 137;
            this.IconMin.TabStop = false;
            this.IconMin.Click += new System.EventHandler(this.IconMin_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPromedio);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtFinal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtParcial);
            this.groupBox5.Controls.Add(this.txtExamen2);
            this.groupBox5.Controls.Add(this.txtExamen1);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtDocente);
            this.groupBox5.Controls.Add(this.txtSeccion);
            this.groupBox5.Controls.Add(this.txtCurso);
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Controls.Add(this.txtMaterno);
            this.groupBox5.Controls.Add(this.txtPaterno);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1077, 304);
            this.groupBox5.TabIndex = 141;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Información del Alumno";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(803, 215);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(238, 36);
            this.txtPromedio.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 27);
            this.label6.TabIndex = 139;
            this.label6.Text = "Promedio";
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(803, 175);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(238, 36);
            this.txtFinal.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(570, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 27);
            this.label9.TabIndex = 137;
            this.label9.Text = "Examen Final";
            // 
            // txtParcial
            // 
            this.txtParcial.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcial.Location = new System.Drawing.Point(803, 135);
            this.txtParcial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(238, 36);
            this.txtParcial.TabIndex = 136;
            // 
            // txtExamen2
            // 
            this.txtExamen2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamen2.Location = new System.Drawing.Point(803, 95);
            this.txtExamen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExamen2.Name = "txtExamen2";
            this.txtExamen2.Size = new System.Drawing.Size(238, 36);
            this.txtExamen2.TabIndex = 135;
            // 
            // txtExamen1
            // 
            this.txtExamen1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamen1.Location = new System.Drawing.Point(803, 55);
            this.txtExamen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExamen1.Name = "txtExamen1";
            this.txtExamen1.Size = new System.Drawing.Size(238, 36);
            this.txtExamen1.TabIndex = 134;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(570, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 27);
            this.label14.TabIndex = 133;
            this.label14.Text = "Examen Parcial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(570, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 27);
            this.label15.TabIndex = 132;
            this.label15.Text = "Examen 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(571, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 27);
            this.label16.TabIndex = 131;
            this.label16.Text = "Examen 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 130;
            this.label4.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 127;
            this.label3.Text = "Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 128;
            this.label5.Text = "Sección";
            // 
            // txtDocente
            // 
            this.txtDocente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(263, 246);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(238, 36);
            this.txtDocente.TabIndex = 33;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.Location = new System.Drawing.Point(263, 206);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(238, 36);
            this.txtSeccion.TabIndex = 32;
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(263, 166);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(238, 36);
            this.txtCurso.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(263, 126);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 36);
            this.txtNombre.TabIndex = 27;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(263, 86);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(238, 36);
            this.txtMaterno.TabIndex = 26;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(263, 46);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(238, 36);
            this.txtPaterno.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(28, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 27);
            this.label20.TabIndex = 24;
            this.label20.Text = "Nombre";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(28, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(213, 27);
            this.label22.TabIndex = 23;
            this.label22.Text = "Apellido Materno";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(28, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(204, 27);
            this.label23.TabIndex = 22;
            this.label23.Text = "Apellido Paterno";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(1039, 329);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 73);
            this.panel3.TabIndex = 143;
            // 
            // btnPromedios
            // 
            this.btnPromedios.FlatAppearance.BorderSize = 0;
            this.btnPromedios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnPromedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromedios.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedios.ForeColor = System.Drawing.Color.White;
            this.btnPromedios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromedios.Location = new System.Drawing.Point(659, 329);
            this.btnPromedios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(394, 73);
            this.btnPromedios.TabIndex = 142;
            this.btnPromedios.Text = "Calcular Nuevo Promedio";
            this.btnPromedios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1503, 832);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.IconExit);
            this.Controls.Add(this.IconMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnAgregarNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditarNotas";
            this.Text = "Editar Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnAgregarNotas;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.PictureBox IconExit;
        private System.Windows.Forms.PictureBox IconMin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtExamen2;
        private System.Windows.Forms.TextBox txtExamen1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn apaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn amaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn final;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
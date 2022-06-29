namespace ProyectoFinal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.IconExit = new System.Windows.Forms.PictureBox();
            this.IconMin = new System.Windows.Forms.PictureBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.panelacciones1 = new System.Windows.Forms.Panel();
            this.panelacciones2 = new System.Windows.Forms.Panel();
            this.btnCargarDatosOp = new System.Windows.Forms.Button();
            this.btnRegistrarOp = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbSeccion = new System.Windows.Forms.TextBox();
            this.btnSeccion = new System.Windows.Forms.Button();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.IconExit);
            this.panel1.Controls.Add(this.IconMin);
            this.panel1.Controls.Add(this.lblGrado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 69);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1271, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 147;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // IconExit
            // 
            this.IconExit.Image = ((System.Drawing.Image)(resources.GetObject("IconExit.Image")));
            this.IconExit.Location = new System.Drawing.Point(1371, 9);
            this.IconExit.Name = "IconExit";
            this.IconExit.Size = new System.Drawing.Size(44, 51);
            this.IconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconExit.TabIndex = 12;
            this.IconExit.TabStop = false;
            this.IconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // IconMin
            // 
            this.IconMin.Image = ((System.Drawing.Image)(resources.GetObject("IconMin.Image")));
            this.IconMin.Location = new System.Drawing.Point(1321, 9);
            this.IconMin.Name = "IconMin";
            this.IconMin.Size = new System.Drawing.Size(44, 51);
            this.IconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMin.TabIndex = 9;
            this.IconMin.TabStop = false;
            this.IconMin.Click += new System.EventHandler(this.IconMin_Click);
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.White;
            this.lblGrado.Location = new System.Drawing.Point(100, 9);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(817, 54);
            this.lblGrado.TabIndex = 5;
            this.lblGrado.Text = "Registro de Notas Nivel Secundaria";
            // 
            // panelacciones1
            // 
            this.panelacciones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panelacciones1.Location = new System.Drawing.Point(1121, 327);
            this.panelacciones1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelacciones1.Name = "panelacciones1";
            this.panelacciones1.Size = new System.Drawing.Size(13, 73);
            this.panelacciones1.TabIndex = 128;
            // 
            // panelacciones2
            // 
            this.panelacciones2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panelacciones2.Location = new System.Drawing.Point(1402, 326);
            this.panelacciones2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelacciones2.Name = "panelacciones2";
            this.panelacciones2.Size = new System.Drawing.Size(13, 73);
            this.panelacciones2.TabIndex = 115;
            // 
            // btnCargarDatosOp
            // 
            this.btnCargarDatosOp.FlatAppearance.BorderSize = 0;
            this.btnCargarDatosOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnCargarDatosOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatosOp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatosOp.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatosOp.Location = new System.Drawing.Point(1140, 326);
            this.btnCargarDatosOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarDatosOp.Name = "btnCargarDatosOp";
            this.btnCargarDatosOp.Size = new System.Drawing.Size(275, 73);
            this.btnCargarDatosOp.TabIndex = 114;
            this.btnCargarDatosOp.Text = "Cargar Registro";
            this.btnCargarDatosOp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarDatosOp.UseVisualStyleBackColor = true;
            this.btnCargarDatosOp.Click += new System.EventHandler(this.btnCargarDatosOp_Click);
            // 
            // btnRegistrarOp
            // 
            this.btnRegistrarOp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnRegistrarOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarOp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarOp.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarOp.Location = new System.Drawing.Point(859, 326);
            this.btnRegistrarOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarOp.Name = "btnRegistrarOp";
            this.btnRegistrarOp.Size = new System.Drawing.Size(275, 73);
            this.btnRegistrarOp.TabIndex = 112;
            this.btnRegistrarOp.Text = "Registrar";
            this.btnRegistrarOp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarOp.UseVisualStyleBackColor = true;
            this.btnRegistrarOp.Click += new System.EventHandler(this.btnRegistrarOp_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos TXT(*.txt)|*.txt";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel13);
            this.groupBox1.Controls.Add(this.cbSeccion);
            this.groupBox1.Controls.Add(this.btnSeccion);
            this.groupBox1.Controls.Add(this.cbTurno);
            this.groupBox1.Controls.Add(this.cbArea);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDocente);
            this.groupBox1.Controls.Add(this.txtMaterno);
            this.groupBox1.Controls.Add(this.txtPaterno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1403, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Alumno";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.panel13.Location = new System.Drawing.Point(1381, 43);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(11, 38);
            this.panel13.TabIndex = 124;
            // 
            // cbSeccion
            // 
            this.cbSeccion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.Location = new System.Drawing.Point(920, 41);
            this.cbSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(351, 36);
            this.cbSeccion.TabIndex = 16;
            // 
            // btnSeccion
            // 
            this.btnSeccion.FlatAppearance.BorderSize = 0;
            this.btnSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeccion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeccion.ForeColor = System.Drawing.Color.White;
            this.btnSeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeccion.Location = new System.Drawing.Point(1287, 43);
            this.btnSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeccion.Name = "btnSeccion";
            this.btnSeccion.Size = new System.Drawing.Size(104, 38);
            this.btnSeccion.TabIndex = 125;
            this.btnSeccion.Text = "STOP";
            this.btnSeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeccion.UseVisualStyleBackColor = true;
            this.btnSeccion.Click += new System.EventHandler(this.btnSeccion_Click);
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cbTurno.Location = new System.Drawing.Point(920, 126);
            this.cbTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(351, 35);
            this.cbTurno.TabIndex = 18;
            this.cbTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTurno_KeyPress);
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Matemática",
            "Comunicación",
            "Ciencia y Tecnología",
            "Educación Física",
            "Arte y Cultura",
            "Ingles",
            "Cívica"});
            this.cbArea.Location = new System.Drawing.Point(277, 171);
            this.cbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(351, 35);
            this.cbArea.TabIndex = 15;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged_1);
            this.cbArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbArea_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(277, 129);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(351, 36);
            this.txtNombre.TabIndex = 13;
            // 
            // txtDocente
            // 
            this.txtDocente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(920, 82);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(351, 36);
            this.txtDocente.TabIndex = 12;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(277, 87);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(351, 36);
            this.txtMaterno.TabIndex = 8;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(277, 46);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(351, 36);
            this.txtPaterno.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(675, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Turno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(675, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Docente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Área";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(675, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sección (aleatorio)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido Paterno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.curso,
            this.paterno,
            this.materno,
            this.nombrea,
            this.seccion,
            this.docente,
            this.turno});
            this.dataGridView1.Location = new System.Drawing.Point(12, 425);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de Ingreso";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // curso
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.curso.DefaultCellStyle = dataGridViewCellStyle1;
            this.curso.HeaderText = "Curso";
            this.curso.MinimumWidth = 6;
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 125;
            // 
            // paterno
            // 
            this.paterno.HeaderText = "A. Paterno";
            this.paterno.MinimumWidth = 6;
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            this.paterno.Width = 125;
            // 
            // materno
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.materno.DefaultCellStyle = dataGridViewCellStyle2;
            this.materno.HeaderText = "A. Materno";
            this.materno.MinimumWidth = 6;
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            this.materno.Width = 125;
            // 
            // nombrea
            // 
            this.nombrea.HeaderText = "Nombre";
            this.nombrea.MinimumWidth = 6;
            this.nombrea.Name = "nombrea";
            this.nombrea.ReadOnly = true;
            this.nombrea.Width = 125;
            // 
            // seccion
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.seccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.seccion.HeaderText = "Sección";
            this.seccion.MinimumWidth = 6;
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            this.seccion.Width = 125;
            // 
            // docente
            // 
            this.docente.HeaderText = "Docente";
            this.docente.MinimumWidth = 6;
            this.docente.Name = "docente";
            this.docente.ReadOnly = true;
            this.docente.Width = 125;
            // 
            // turno
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(184)))), ((int)(((byte)(48)))));
            this.turno.DefaultCellStyle = dataGridViewCellStyle4;
            this.turno.HeaderText = "Turno";
            this.turno.MinimumWidth = 6;
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 125;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1445, 781);
            this.ControlBox = false;
            this.Controls.Add(this.panelacciones1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelacciones2);
            this.Controls.Add(this.btnCargarDatosOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarOp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Panel panelacciones2;
        private System.Windows.Forms.Button btnCargarDatosOp;
        private System.Windows.Forms.Button btnRegistrarOp;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelacciones1;
        private System.Windows.Forms.PictureBox IconExit;
        private System.Windows.Forms.PictureBox IconMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox cbSeccion;
        private System.Windows.Forms.Button btnSeccion;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrea;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
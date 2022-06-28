using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Registro : Form
    {
        public string ruta = "";

        public Registro(string rutaprincipal)
        {
            InitializeComponent();

            tamaño_data();

            //Desactivado
            cbSeccion.Enabled = false;
            txtDocente.Enabled = false;
            ruta = rutaprincipal;
        }

        //Ruta
        public void Archivo(string ruta_principal)
        {
            string titulo = "";

            if (ruta_principal == "1ro secundaria.txt")
            {
                titulo = "Registro de Notas Nivel Secundaria 1er grado";
            }
            else if (ruta_principal == "2do secundaria.txt")
            {
                titulo = "Registro de Notas Nivel Secundaria 2do grado";
            }
            else if (ruta_principal == "3ro secundaria.txt")
            {
                titulo = "Registro de Notas Nivel Secundaria 3er grado";
            }
            else if (ruta_principal == "4to secundaria.txt")
            {
                titulo = "Registro de Notas Nivel Secundaria 4to grado";
            }
            else if (ruta_principal == "5to secundaria.txt")
            {
                titulo = "Registro de Notas Nivel Secundaria 5to grado";
            }

            lblGrado.Text = titulo;

            DatosRegistrados();
        }

        //Cambiar tamaños DGV
        public void tamaño_data()
        {
            dataGridView1.Columns[0].Width = 80;
        }

        Validacion validacion = new Validacion();
        List<Alumno> alumno = new List<Alumno>();

        //Datos File Registrados
        public void DatosRegistrados()
        {
            if (File.Exists(ruta))
            {
                string[] datos = new string[12];
                string registro = "";

                StreamReader leer = File.OpenText(ruta);

                dataGridView1.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    dataGridView1.Rows.Add(datos[0].Trim(),
                                           datos[1].Trim(),
                                           datos[2].Trim(),
                                           datos[3].Trim(),
                                           datos[4].Trim(),
                                           datos[5].Trim(),
                                           datos[6].Trim(),
                                           datos[7].Trim());
                }

                leer.Close();
            }
        }

        //Creacion de Archivo txt por si no existe
        public void CrearArchivo()
        {
            try
            {
                StreamWriter escribir = File.CreateText(ruta);

                foreach (Alumno objAlumno in alumno)
                {
                    escribir.WriteLine(objAlumno.fecha.ToShortDateString() + " | " +
                                               objAlumno.curso + " | " +
                                               objAlumno.paterno + " | " +
                                               objAlumno.materno + " | " +
                                               objAlumno.nombre + " | " +
                                               objAlumno.seccion + " | " +
                                               objAlumno.docente + " | " +
                                               objAlumno.turno + " | " +
                                               objAlumno.exam1 + " | " +
                                               objAlumno.exam2 + " | " +
                                               objAlumno.parcial + " | " +
                                               objAlumno.final + " | " +
                                               objAlumno.promedio.ToString("0.00"));

                    escribir.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        //Registrar Alumno
        private void btnRegistrarOp_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(cbArea, "");
            errorProvider.SetError(cbSeccion, "");
            errorProvider.SetError(txtDocente, "");
            errorProvider.SetError(cbTurno, "");

            errorProvider.SetError(txtPaterno, "");
            errorProvider.SetError(txtMaterno, "");
            errorProvider.SetError(txtNombre, "");

            bool flag = true;

            string paterno, materno, nombre;
            string area, seccion, docente, turno;

            try
            {
                paterno = txtPaterno.Text;
                if (validacion.Vacio(txtPaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.SoloLetras(txtPaterno.Text)) { throw new Exception("Solo letras."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtPaterno, ex.Message); flag = false; }

            try
            {
                materno = txtMaterno.Text;
                if (validacion.Vacio(txtMaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.SoloLetras(txtMaterno.Text)) { throw new Exception("Solo letras."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtMaterno, ex.Message); flag = false; }

            try
            {
                nombre = txtNombre.Text;
                if (validacion.Vacio(txtNombre.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.SoloLetras(txtNombre.Text)) { throw new Exception("Solo letras."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtNombre, ex.Message); flag = false; }

            try
            {
                area = cbArea.Text;
                if (validacion.Vacio(cbArea.Text)) { throw new Exception("No puede estar vacio."); }
            }
            catch (Exception ex) { errorProvider.SetError(cbArea, ex.Message); flag = false; }

            try
            {
                seccion = cbSeccion.Text;
                if (validacion.Vacio(cbSeccion.Text)) { throw new Exception("No puede estar vacio."); }
                if (btnSeccion.Text == "STOP") { throw new Exception("Debes de presionar 'STOP' para\nelegir una sección aleatoriamente."); }
            }
            catch (Exception ex) { errorProvider.SetError(cbSeccion, ex.Message); flag = false; }

            try
            {
                docente = txtDocente.Text;
                if (validacion.Vacio(txtDocente.Text)) { throw new Exception("Debe seleccionar una Área del Profesor."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtDocente, ex.Message); flag = false; }

            try
            {
                turno = cbTurno.Text;
                if (validacion.Vacio(cbTurno.Text)) { throw new Exception("No puede estar vacio."); }
            }
            catch (Exception ex) { errorProvider.SetError(cbTurno, ex.Message); flag = false; }



            if (flag)
            {
                Alumno objAlumno = new Alumno();

                objAlumno.fecha = DateTime.Now;
                objAlumno.curso = cbArea.Text;
                objAlumno.seccion = cbSeccion.Text;
                objAlumno.docente = txtDocente.Text;
                objAlumno.turno = cbTurno.Text;

                objAlumno.paterno = txtPaterno.Text;
                objAlumno.materno = txtMaterno.Text;
                objAlumno.nombre = txtNombre.Text;

                objAlumno.curso = cbArea.Text;
                objAlumno.materno = txtPaterno.Text;
                objAlumno.paterno = txtPaterno.Text;
                objAlumno.nombre = txtNombre.Text;
                objAlumno.exam1 = 0;
                objAlumno.exam2 = 0;
                objAlumno.parcial = 0;
                objAlumno.final = 0;
                objAlumno.promedio = (objAlumno.exam1 * 0.15f) + (objAlumno.exam2 * 0.15f) + (objAlumno.parcial * 0.3f) + (objAlumno.final * 0.4f);

                alumno.Add(objAlumno);

                dataGridView1.Rows.Add(objAlumno.fecha.ToShortDateString(),
                                       objAlumno.curso,
                                       objAlumno.paterno,
                                       objAlumno.materno,
                                       objAlumno.nombre,
                                       objAlumno.seccion,
                                       objAlumno.docente,
                                       objAlumno.turno);

                try
                {
                    if (File.Exists(ruta))
                    {
                        StreamWriter escribir = new StreamWriter(ruta, append: true);

                        escribir.WriteLine(objAlumno.fecha.ToShortDateString() + " | " +
                                               objAlumno.curso + " | " +
                                               objAlumno.paterno + " | " +
                                               objAlumno.materno + " | " +
                                               objAlumno.nombre + " | " +
                                               objAlumno.seccion + " | " +
                                               objAlumno.docente + " | " +
                                               objAlumno.turno + " | " +
                                               objAlumno.exam1 + " | " +
                                               objAlumno.exam2 + " | " +
                                               objAlumno.parcial + " | " +
                                               objAlumno.final + " | " +
                                               objAlumno.promedio.ToString("0.00"));

                        escribir.Close();
                    }
                    else
                    {
                        CrearArchivo();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el registro: " + ex.Message);
                }

                LimpiarCampos();
                MessageBox.Show("Se ha registrado al alumno en el sistema correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        //Cargar Datos - OpenFile
        private void btnCargarDatosOp_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Buscar Registro Secundaria";

            try
            {
                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName) && openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = this.openFileDialog1.FileName;

                    string[] datos = new string[12];
                    string registro = "";

                    StreamReader leer = File.OpenText(ruta);

                    if (Path.GetFileName(ruta) == "1ro secundaria.txt")
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria 1er grado";
                    }
                    else if (Path.GetFileName(ruta) == "2do secundaria.txt")
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria 2do grado";
                    }
                    else if (Path.GetFileName(ruta) == "3ro secundaria.txt")
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria 3er grado";
                    }
                    else if (Path.GetFileName(ruta) == "4to secundaria.txt")
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria 4to grado";
                    }
                    else if (Path.GetFileName(ruta) == "5to secundaria.txt")
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria 5to grado";
                    }
                    else
                    {
                        lblGrado.Text = "Registro de Notas Nivel Secundaria";
                    }

                    dataGridView1.Rows.Clear();

                    while (!leer.EndOfStream)
                    {
                        registro = leer.ReadLine();
                        datos = registro.Split('|');

                        dataGridView1.Rows.Add(datos[0].Trim(),
                                               datos[1].Trim(),
                                               datos[2].Trim(),
                                               datos[3].Trim(),
                                               datos[4].Trim(),
                                               datos[5].Trim(),
                                               datos[6].Trim(),
                                               datos[7].Trim());
                    }

                    leer.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes de seleccionar un registro.", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar Campos
        public void LimpiarCampos()
        {
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            txtNombre.Text = String.Empty;
            cbArea.Text = String.Empty;
            cbSeccion.Text = String.Empty;
            txtDocente.Text = String.Empty;
            cbTurno.Text = String.Empty;
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Opciones formOpciones = new Opciones(ruta);
            formOpciones.Show();
        }
        private void IconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Seccion Aleatorio
        private void btnSeccion_Click(object sender, EventArgs e)
        {
            if (btnSeccion.Text == "ON")
            {
                timer1.Start();
                timer1.Enabled = true;
                btnSeccion.Text = "STOP";
            }
            else if (btnSeccion.Text == "STOP")
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnSeccion.Text = "ON";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int linea_longitud = File.ReadAllLines("SeccionAleatorio.txt").Length;
            Random rdn = new Random();
            int lineas_Random = rdn.Next(0, linea_longitud + 1); // A-B-C-D

            StreamReader archivo = File.OpenText("SeccionAleatorio.txt");

            string linea = null;
            int i = 0;

            while (!archivo.EndOfStream)
            {
                linea = archivo.ReadLine();
                if (++i == lineas_Random)
                    break;
            }

            cbSeccion.Text = linea;
        }

        //No poder escribir en ComboBox
        private void cbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Docente depende del Area
        private void cbArea_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indice = cbArea.SelectedIndex;

            if (indice.ToString() == "0") //Prof. 1
            {
                txtDocente.Text = "Luz N.";
            }
            else if (indice.ToString() == "1") //Prof. 2
            {
                txtDocente.Text = "Amity B.";
            }
            else if (indice.ToString() == "2") //Prof. 3
            {
                txtDocente.Text = "Gus P.";
            }
            else if (indice.ToString() == "3") //Prof. 4
            {
                txtDocente.Text = "Willow P.";
            }
            else if (indice.ToString() == "4") //Prof. 5
            {
                txtDocente.Text = "Lilith C.";
            }
            else if (indice.ToString() == "5") //Prof. 6
            {
                txtDocente.Text = "Edalyn C.";
            }
            else if (indice.ToString() == "6") //Prof. 7
            {
                txtDocente.Text = "Raine W.";
            }
        }
    }
}

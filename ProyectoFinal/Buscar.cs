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
    public partial class Buscar : Form
    {
        public string ruta = "";
        Validacion validacion = new Validacion();

        public Buscar(string rutaprincipal)
        {
            InitializeComponent();
            tamaño_data();

            ruta = rutaprincipal;

            //visible - invisible
            cbBuscarSegun.Visible = true;
            txtBuscarNombre.Visible = false;

            cbBuscarSegun.Enabled = false;

            txtCurso.Enabled = false;
            txtNombre.Enabled = false;
            txtPaterno.Enabled = false;
            txtMaterno.Enabled = false;
            txtSeccion.Enabled = false;
            txtDocente.Enabled = false;
            txtTurno.Enabled = false;

            txtExamen1.Enabled = false;
            txtExamen2.Enabled = false;
            txtParcial.Enabled = false;
            txtFinal.Enabled = false;
            txtPromedio.Enabled = false;
        }

        //Cambiar tamaños DGV
        public void tamaño_data()
        {
            dataGridViewBuscar.Columns[1].Width = 80;
            dataGridViewBuscar.Columns[2].Width = 80;
            dataGridViewBuscar.Columns[3].Width = 80;
            dataGridViewBuscar.Columns[4].Width = 55;
            dataGridViewBuscar.Columns[5].Width = 70;
            dataGridViewBuscar.Columns[6].Width = 70;
            dataGridViewBuscar.Columns[7].Width = 80;
            dataGridViewBuscar.Columns[8].Width = 80;
            dataGridViewBuscar.Columns[9].Width = 80;
            dataGridViewBuscar.Columns[10].Width = 80;
            dataGridViewBuscar.Columns[11].Width = 80;
        }

        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string buscar;
            string selec;
            errorProvider.SetError(cbBuscar, "");
            errorProvider.SetError(txtBuscarNombre, "");
            errorProvider.SetError(cbBuscarSegun, "");

            try
            {
                selec = cbBuscar.Text;
                if (validacion.Vacio(cbBuscar.Text)) { throw new Exception("Debe seleccionar\n una opcíón de búsqueda."); }
            }
            catch (Exception ex) { errorProvider.SetError(cbBuscar, ex.Message); flag = false; }

            if (lblBuscarPor.Text == "Buscar por Nombre")
            {
                try
                {
                    buscar = txtBuscarNombre.Text;
                    if (validacion.Vacio(txtBuscarNombre.Text)) { throw new Exception("No puede estar vacio."); }
                    if (validacion.SoloLetras(txtBuscarNombre.Text)) { throw new Exception("Solo letras."); }
                }
                catch (Exception ex) { errorProvider.SetError(txtBuscarNombre, ex.Message); flag = false; }
            }
            else
            {
                try
                {
                    buscar = cbBuscarSegun.Text;
                    if (validacion.Vacio(cbBuscarSegun.Text)) { throw new Exception("Debe seleccionar\n una opcíón de búsqueda."); }
                }
                catch (Exception ex) { errorProvider.SetError(cbBuscarSegun, ex.Message); flag = false; }
            }


            if (File.Exists(ruta) && flag)
            {
                string[] datos = new string[12];
                string registro = "";
                bool encontrado = false;

                StreamReader leer = File.OpenText(ruta);

                dataGridViewBuscar.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    //area
                    if (cbBuscar.Text == "Area")
                    {
                        encontrado = true;
                        BuscarArchivo(datos, ruta, dataGridViewBuscar, 1, cbBuscarSegun.Text, cbBuscar, "Area");
                    }
                    //seccion
                    else if (cbBuscar.Text == "Seccion")
                    {
                        encontrado = true;
                        BuscarArchivo(datos, ruta, dataGridViewBuscar, 5, cbBuscarSegun.Text, cbBuscar, "Seccion");
                    }
                    //por turno
                    else if (cbBuscar.Text == "Turno")
                    {
                        encontrado = true;
                        BuscarArchivo(datos, ruta, dataGridViewBuscar, 7, cbBuscarSegun.Text, cbBuscar, "Turno");
                    }
                    //nombre
                    else if (cbBuscar.Text == "Nombre")
                    {
                        encontrado = true;
                        BuscarArchivo(datos, ruta, dataGridViewBuscar, 4, txtBuscarNombre.Text, cbBuscar, "Nombre");
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("No hay contenido disponible o\nno existe alumnos registrados correspondiente a lo que busca.");
                }

                leer.Close();

                cbBuscar.Text = String.Empty;
                txtBuscarNombre.Text = String.Empty;
                cbBuscarSegun.Text = String.Empty;

            }
        }

        //Ver registro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            DatosRegistrados();
        }

        //Metodo ver registro
        public void DatosRegistrados()
        {
            if (File.Exists(ruta))
            {
                string[] datos = new string[12];
                string registro = "";

                StreamReader leer = File.OpenText(ruta);

                dataGridViewBuscar.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    dataGridViewBuscar.Rows.Add(datos[1].Trim(),
                                           datos[2].Trim(),
                                           datos[3].Trim(),
                                           datos[4].Trim(),
                                           datos[5].Trim(),
                                           datos[6].Trim(),
                                           datos[7].Trim(),
                                           datos[8].Trim(),
                                           datos[9].Trim(),
                                           datos[10].Trim(),
                                           datos[11].Trim(),
                                           datos[12].Trim());
                }

                leer.Close();
            }
        }

        //Label Buscar por cbBuscar y agregar items segun cbBuscar
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbBuscar.SelectedIndex;

            if (indice.ToString() == "0") //area
            {
                cbBuscarSegun.Enabled = true;
                cbBuscarSegun.Visible = true;
                txtBuscarNombre.Visible = false;
                cbBuscarSegun.Items.Clear();
                cbBuscarSegun.Text = "";

                lblBuscarPor.Text = "Buscar por Area";
                cbBuscarSegun.Items.Add("Matemática");
                cbBuscarSegun.Items.Add("Comunicación");
                cbBuscarSegun.Items.Add("Ciencia y Tecnología");
                cbBuscarSegun.Items.Add("Educación Física");
                cbBuscarSegun.Items.Add("Arte y Cultura");
                cbBuscarSegun.Items.Add("Ingles");
                cbBuscarSegun.Items.Add("Cívica");

                cbBuscarSegun.Focus();
            }
            else if (indice.ToString() == "1") //seccion
            {
                cbBuscarSegun.Enabled = true;
                cbBuscarSegun.Visible = true;
                txtBuscarNombre.Visible = false;
                cbBuscarSegun.Items.Clear();
                cbBuscarSegun.Text = "";

                lblBuscarPor.Text = "Buscar por Seccion";
                cbBuscarSegun.Items.Add("A");
                cbBuscarSegun.Items.Add("B");
                cbBuscarSegun.Items.Add("C");
                cbBuscarSegun.Items.Add("D");

                cbBuscarSegun.Focus();
            }
            else if (indice.ToString() == "2") //turno
            {
                cbBuscarSegun.Enabled = true;
                cbBuscarSegun.Visible = true;
                txtBuscarNombre.Visible = false;
                cbBuscarSegun.Items.Clear();
                cbBuscarSegun.Text = "";

                lblBuscarPor.Text = "Buscar por Turno";
                cbBuscarSegun.Items.Add("Mañana");
                cbBuscarSegun.Items.Add("Tarde");

                cbBuscarSegun.Focus();
            }
            else if (indice.ToString() == "3") //nombre
            {
                cbBuscarSegun.Enabled = true;
                cbBuscarSegun.Visible = false;
                txtBuscarNombre.Visible = true;
                cbBuscarSegun.Items.Clear();
                cbBuscarSegun.Text = "";
                txtBuscarNombre.Text = "";

                lblBuscarPor.Text = "Buscar por Nombre";

                txtBuscarNombre.Focus();
            }
        }

        //Metodo Buscar en Archivo
        public void BuscarArchivo(string[] datos, string rutaguia, DataGridView dgv, int pos, string cb_segun, ComboBox buscarpor, string pordonde)
        {
            datos = new string[12];
            string registro = "";

            StreamReader leer = File.OpenText(rutaguia);

            dgv.Rows.Clear();

            while (!leer.EndOfStream)
            {
                registro = leer.ReadLine();
                datos = registro.Split('|');

                //area
                if (buscarpor.Text == pordonde)
                {
                    if (datos[pos].Trim().Equals(cb_segun))
                    {
                        dgv.Rows.Add(datos[1].Trim(),
                                       datos[2].Trim(),
                                       datos[3].Trim(),
                                       datos[4].Trim(),
                                       datos[5].Trim(),
                                       datos[6].Trim(),
                                       datos[7].Trim(),
                                       datos[8].Trim(),
                                       datos[9].Trim(),
                                       datos[10].Trim(),
                                       datos[11].Trim(),
                                       datos[12].Trim());
                    }
                }
            }

            leer.Close();
        }

        //DataGridView posicion
        private void dataGridViewBuscar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicion = dataGridViewBuscar.CurrentRow.Index;

            txtCurso.Text = dataGridViewBuscar.Rows[posicion].Cells[0].Value.ToString();
            txtNombre.Text = dataGridViewBuscar.Rows[posicion].Cells[1].Value.ToString();
            txtPaterno.Text = dataGridViewBuscar.Rows[posicion].Cells[2].Value.ToString();
            txtMaterno.Text = dataGridViewBuscar.Rows[posicion].Cells[3].Value.ToString();
            txtSeccion.Text = dataGridViewBuscar.Rows[posicion].Cells[4].Value.ToString();
            txtDocente.Text = dataGridViewBuscar.Rows[posicion].Cells[5].Value.ToString();
            txtTurno.Text = dataGridViewBuscar.Rows[posicion].Cells[6].Value.ToString();

            txtExamen1.Text = dataGridViewBuscar.Rows[posicion].Cells[7].Value.ToString();
            txtExamen2.Text = dataGridViewBuscar.Rows[posicion].Cells[8].Value.ToString();
            txtParcial.Text = dataGridViewBuscar.Rows[posicion].Cells[9].Value.ToString();
            txtFinal.Text = dataGridViewBuscar.Rows[posicion].Cells[10].Value.ToString();
            txtPromedio.Text = dataGridViewBuscar.Rows[posicion].Cells[11].Value.ToString();
        }

        //No poder escribir en ComboBox
        private void cbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbBuscarSegun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
    }
}

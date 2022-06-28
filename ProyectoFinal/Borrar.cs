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
    public partial class Borrar : Form
    {
        public string ruta = "";

        public Borrar(string rutaprincipal)
        {
            InitializeComponent();
            tamaño_data();

            ruta = rutaprincipal;

            txtCurso.Enabled = false;
            txtNombre.Enabled = false;
            txtPaterno.Enabled = false;
            txtMaterno.Enabled = false;
            txtSeccion.Enabled = false;
            txtDocente.Enabled = false;
            txtTurno.Enabled = false;
        }

        //Cambiar tamaños DGV
        public void tamaño_data()
        {
            dataGridViewBorrar.Columns[1].Width = 90;
            dataGridViewBorrar.Columns[2].Width = 90;
            dataGridViewBorrar.Columns[3].Width = 90;
            dataGridViewBorrar.Columns[4].Width = 55;
            dataGridViewBorrar.Columns[5].Width = 80;
            dataGridViewBorrar.Columns[6].Width = 80;
        }

        //Ver registro
        public void DatosRegistrados()
        {
            if (File.Exists(ruta))
            {
                string[] datos = new string[12];
                string registro = "";

                StreamReader leer = File.OpenText(ruta);

                dataGridViewBorrar.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    dataGridViewBorrar.Rows.Add(datos[1].Trim(),
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

        Validacion validacion = new Validacion();

        //Borrar segun seleccion dgv
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            bool flag = true;

            try
            {
                if (validacion.Vacio(txtCurso.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtPaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtMaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtNombre.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtSeccion.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtDocente.Text)) { throw new Exception("No puede estar vacio."); }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes seleccionar una fila del DataGridView para poder llenar los campos de información.\n" +
                                "Una vez los campos esten llenos podrá eliminar al alumno.", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (flag)
            {
                int posicion = dataGridViewBorrar.CurrentRow.Index;
                Eliminar_EnArchivo(ruta, posicion);
                Mostrar_DGV(dataGridViewBorrar, ruta);

                txtCurso.Text = String.Empty;
                txtNombre.Text = String.Empty;
                txtPaterno.Text = String.Empty;
                txtMaterno.Text = String.Empty;
                txtSeccion.Text = String.Empty;
                txtDocente.Text = String.Empty;
                txtTurno.Text = String.Empty;
            }
        }

        //Metodo eliminar en archivo
        public void Eliminar_EnArchivo(string rutaguia, int posicion)
        {
            StreamReader leer = new StreamReader(rutaguia);

            int contador = 0;
            string cadena = "";

            while (!leer.EndOfStream)
            {
                string registro = leer.ReadLine();

                if (contador != posicion)
                {

                    cadena += registro + "\r\n";
                }

                contador++;
            }

            leer.Close();
            File.WriteAllText(rutaguia, cadena);
        }

        //Metodo mostrar en dgv 
        public void Mostrar_DGV(DataGridView dgv, string rutaguia)
        {
            int Columns = dgv.Columns.Count;

            string[] datos = new string[12];
            string registro = "";

            StreamReader leer = new StreamReader(rutaguia);

            dgv.Rows.Clear();

            while (!leer.EndOfStream)
            {
                registro = leer.ReadLine();
                datos = registro.Split('|');

                dgv.Rows.Add(datos[1].Trim(),
                             datos[2].Trim(),
                             datos[3].Trim(),
                             datos[4].Trim(),
                             datos[5].Trim(),
                             datos[6].Trim(),
                             datos[7].Trim());
            }

            leer.Close();

        }

        //DataGridView posicion
        private void dataGridViewBorrar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicion = dataGridViewBorrar.CurrentRow.Index;

            txtCurso.Text = dataGridViewBorrar.Rows[posicion].Cells[0].Value.ToString();
            txtNombre.Text = dataGridViewBorrar.Rows[posicion].Cells[1].Value.ToString();
            txtPaterno.Text = dataGridViewBorrar.Rows[posicion].Cells[2].Value.ToString();
            txtMaterno.Text = dataGridViewBorrar.Rows[posicion].Cells[3].Value.ToString();
            txtSeccion.Text = dataGridViewBorrar.Rows[posicion].Cells[4].Value.ToString();
            txtDocente.Text = dataGridViewBorrar.Rows[posicion].Cells[5].Value.ToString();
            txtTurno.Text = dataGridViewBorrar.Rows[posicion].Cells[6].Value.ToString();
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

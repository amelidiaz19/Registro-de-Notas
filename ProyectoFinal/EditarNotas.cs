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
    public partial class EditarNotas : Form
    {
        public string ruta = "";

        public EditarNotas(string rutaprincipal)
        {
            InitializeComponent();
            tamaño_data();

            ruta = rutaprincipal;

            btnAplicar.Enabled = false;

            txtCurso.Enabled = false;
            txtPaterno.Enabled = false;
            txtMaterno.Enabled = false;
            txtNombre.Enabled = false;
            txtSeccion.Enabled = false;
            txtDocente.Enabled = false;

            txtExamen1.Enabled = false;
            txtExamen2.Enabled = false;
            txtParcial.Enabled = false;
            txtFinal.Enabled = false;

            txtPromedio.Enabled = false;
        }

        //Cambiar tamaños DGV
        public void tamaño_data()
        {
            dataGridViewNotas.Columns[0].Width = 70;
            dataGridViewNotas.Columns[2].Width = 80;
            dataGridViewNotas.Columns[3].Width = 80;
            dataGridViewNotas.Columns[4].Width = 80;
            dataGridViewNotas.Columns[5].Width = 55;
            dataGridViewNotas.Columns[6].Width = 80;
            dataGridViewNotas.Columns[7].Width = 80;
            dataGridViewNotas.Columns[8].Width = 80;
            dataGridViewNotas.Columns[9].Width = 80;
            dataGridViewNotas.Columns[10].Width = 80;
            dataGridViewNotas.Columns[11].Width = 80;
            dataGridViewNotas.Columns[12].Width = 80;
        }

        Validacion validacion = new Validacion();

        //Agregar/ cambiar notas
        private void btnAgregarNotas_Click(object sender, EventArgs e)
        {
            bool flag = true;

            DialogResult respuesta = DialogResult.Cancel;

            errorProvider.SetError(txtExamen1, "");
            errorProvider.SetError(txtExamen2, "");
            errorProvider.SetError(txtParcial, "");
            errorProvider.SetError(txtFinal, "");

            try
            {
                if (validacion.Vacio(txtCurso.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtPaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtMaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtNombre.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtSeccion.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtDocente.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtExamen1.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtExamen2.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtParcial.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtFinal.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtPromedio.Text)) { throw new Exception("No puede estar vacio."); }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes seleccionar una fila del DataGridView para poder llenar los campos de información.\n" +
                                "Una vez los campos esten llenos podrá editar las notas.", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            try
            {
                if (validacion.SoloNumeros(txtExamen1.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtExamen1.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtExamen1, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtExamen2.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtExamen2.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtExamen2, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtParcial.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtParcial.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtParcial, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtFinal.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtFinal.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtFinal, ex.Message); flag = false; }


            if (flag)
            {
                respuesta = MessageBox.Show("¿Está seguro de modificar los datos?", "¡Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                int posicion = dataGridViewNotas.CurrentRow.Index;

                if (respuesta == DialogResult.OK)
                {

                    string fecha = dataGridViewNotas.Rows[posicion].Cells[0].Value.ToString();
                    string curso = dataGridViewNotas.Rows[posicion].Cells[1].Value.ToString();
                    string paterno = dataGridViewNotas.Rows[posicion].Cells[2].Value.ToString();
                    string materno = dataGridViewNotas.Rows[posicion].Cells[3].Value.ToString();
                    string nombre = dataGridViewNotas.Rows[posicion].Cells[4].Value.ToString();
                    string seccion = dataGridViewNotas.Rows[posicion].Cells[5].Value.ToString();
                    string docente = dataGridViewNotas.Rows[posicion].Cells[6].Value.ToString();
                    string turno = dataGridViewNotas.Rows[posicion].Cells[7].Value.ToString();

                    string exam1 = dataGridViewNotas.Rows[posicion].Cells[8].Value.ToString();
                    string exam2 = dataGridViewNotas.Rows[posicion].Cells[9].Value.ToString();
                    string parcial = dataGridViewNotas.Rows[posicion].Cells[10].Value.ToString();
                    string final = dataGridViewNotas.Rows[posicion].Cells[11].Value.ToString();

                    string promedio = dataGridViewNotas.Rows[posicion].Cells[12].Value.ToString();

                    EditarTXT(ruta, fecha + " | " +
                                    curso + " | " +
                                    paterno + " | " +
                                    materno + " | " +
                                    nombre + " | " +
                                    seccion + " | " +
                                    docente + " | " +
                                    turno + " | " +
                                    exam1 + " | " +
                                    exam2 + " | " +
                                    parcial + " | " +
                                    final + " | " +
                                    promedio
                                    ,
                                    fecha + " | " +
                                    curso + " | " +
                                    paterno + " | " +
                                    materno + " | " +
                                    nombre + " | " +
                                    seccion + " | " +
                                    docente + " | " +
                                    turno + " | " +
                                    txtExamen1.Text + " | " +
                                    txtExamen2.Text + " | " +
                                    txtParcial.Text + " | " +
                                    txtFinal.Text + " | " +
                                    txtPromedio.Text);

                    Mostrar_DGV(dataGridViewNotas, ruta);
                }
            }
        }

        //Cambiar promedio
        private void btnPromedios_Click(object sender, EventArgs e)
        {
            bool flag = true;

            errorProvider.SetError(txtExamen1, "");
            errorProvider.SetError(txtExamen2, "");
            errorProvider.SetError(txtParcial, "");
            errorProvider.SetError(txtFinal, "");

            try
            {
                if (validacion.Vacio(txtCurso.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtPaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtMaterno.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtNombre.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtSeccion.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtDocente.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtExamen1.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtExamen2.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtParcial.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtFinal.Text)) { throw new Exception("No puede estar vacio."); }
                if (validacion.Vacio(txtPromedio.Text)) { throw new Exception("No puede estar vacio."); }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes seleccionar una fila del DataGridView para poder llenar los campos de información.\n" +
                                "Una vez los campos esten llenos podrá editar las notas.", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            try
            {
                if (validacion.SoloNumeros(txtExamen1.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtExamen1.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtExamen1, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtExamen2.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtExamen2.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtExamen2, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtParcial.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtParcial.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtParcial, ex.Message); flag = false; }

            try
            {
                if (validacion.SoloNumeros(txtFinal.Text)) { throw new Exception("Solo numeros."); }
                if (validacion.Rango(txtFinal.Text)) { throw new Exception("Solo numeros de 0 a 20."); }
            }
            catch (Exception ex) { errorProvider.SetError(txtFinal, ex.Message); flag = false; }

            if (flag)
            {

                int posicion = dataGridViewNotas.CurrentRow.Index;

                string fecha = dataGridViewNotas.Rows[posicion].Cells[0].Value.ToString();
                string curso = dataGridViewNotas.Rows[posicion].Cells[1].Value.ToString();
                string paterno = dataGridViewNotas.Rows[posicion].Cells[2].Value.ToString();
                string materno = dataGridViewNotas.Rows[posicion].Cells[3].Value.ToString();
                string nombre = dataGridViewNotas.Rows[posicion].Cells[4].Value.ToString();
                string seccion = dataGridViewNotas.Rows[posicion].Cells[5].Value.ToString();
                string docente = dataGridViewNotas.Rows[posicion].Cells[6].Value.ToString();
                string turno = dataGridViewNotas.Rows[posicion].Cells[7].Value.ToString();

                string exam1 = dataGridViewNotas.Rows[posicion].Cells[8].Value.ToString();
                string exam2 = dataGridViewNotas.Rows[posicion].Cells[9].Value.ToString();
                string parcial = dataGridViewNotas.Rows[posicion].Cells[10].Value.ToString();
                string final = dataGridViewNotas.Rows[posicion].Cells[11].Value.ToString();

                string promedio = dataGridViewNotas.Rows[posicion].Cells[12].Value.ToString();

                EditarTXT(ruta, fecha + " | " +
                                curso + " | " +
                                paterno + " | " +
                                materno + " | " +
                                nombre + " | " +
                                seccion + " | " +
                                docente + " | " +
                                turno + " | " +
                                exam1 + " | " +
                                exam2 + " | " +
                                parcial + " | " +
                                final + " | " +
                                promedio
                                ,
                                fecha + " | " +
                                curso + " | " +
                                paterno + " | " +
                                materno + " | " +
                                nombre + " | " +
                                seccion + " | " +
                                docente + " | " +
                                turno + " | " +
                                txtExamen1.Text + " | " +
                                txtExamen2.Text + " | " +
                                txtParcial.Text + " | " +
                                txtFinal.Text + " | " +
                                txtPromedio.Text);

                Mostrar_DGV(dataGridViewNotas, ruta);
            }
        }

        //Metodo modificar
        public void EditarTXT(string Link, string Anterior, string Nuevo)
        {
            StreamReader sr = new StreamReader(Link);
            string txt = "";
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (!line.Equals(Anterior))
                {
                    txt += line + "\r\n";
                }
                else
                {
                    txt += Nuevo + "\r\n";
                }
            }
            sr.Close();
            File.WriteAllText(Link, txt);
        }

        //Mostrar ya modificado
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

                dgv.Rows.Add(datos[0].Trim(),
                             datos[1].Trim(),
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

        //Ver registro
        private void btnNotas_Click(object sender, EventArgs e)
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

                dataGridViewNotas.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    dataGridViewNotas.Rows.Add(datos[0].Trim(),
                                               datos[1].Trim(),
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

        //Ascendente o descendente combobox
        private void cbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbOrdenar.SelectedIndex;

            if (indice.ToString() == "0") // Des
            {
                btnAplicar.Enabled = true;
            }
            else if (indice.ToString() == "1") // Asc
            {
                btnAplicar.Enabled = true;
            }
            else if(indice.ToString() == "2") //Suma
            {
                btnAplicar.Enabled = true;
            }
        }

        //Metodo burbuja ascendete y descendente
        public void Ascendente()
        {
            for (int x = 0; x < dataGridViewNotas.Rows.Count - 1; x++)
            {
                for (int i = 0; i < dataGridViewNotas.Rows.Count - 1; i++)
                {

                    if (double.Parse(dataGridViewNotas.Rows[i].Cells[12].Value.ToString()) < double.Parse(dataGridViewNotas.Rows[i + 1].Cells[12].Value.ToString()))
                    {
                        for (int j = 0; j < 13; j++)
                        {
                            string sus = dataGridViewNotas.Rows[i].Cells[j].Value.ToString();
                            dataGridViewNotas.Rows[i].Cells[j].Value = dataGridViewNotas.Rows[i + 1].Cells[j].Value.ToString();
                            dataGridViewNotas.Rows[i + 1].Cells[j].Value = sus;
                        }

                    }

                }
            }
        }

        public void Descendente()
        {
            for (int x = 0; x < dataGridViewNotas.Rows.Count - 1; x++)
            {
                for (int i = 0; i < dataGridViewNotas.Rows.Count - 1; i++)
                {

                    if (double.Parse(dataGridViewNotas.Rows[i].Cells[12].Value.ToString()) > double.Parse(dataGridViewNotas.Rows[i + 1].Cells[12].Value.ToString()))
                    {
                        for (int j = 0; j < 13; j++)
                        {
                            string sus = dataGridViewNotas.Rows[i].Cells[j].Value.ToString();
                            dataGridViewNotas.Rows[i].Cells[j].Value = dataGridViewNotas.Rows[i + 1].Cells[j].Value.ToString();
                            dataGridViewNotas.Rows[i + 1].Cells[j].Value = sus;
                        }

                    }

                }
            }
        }

        //Aplicar metodo burbuja
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (cbOrdenar.Text == "Descendente")
            {
                Descendente();
            }
            else if (cbOrdenar.Text == "Ascendente")
            {
                Ascendente();
            }
            else if (cbOrdenar.Text == "Sumar Notas")
            {
                SumaNotas();
            }
        }

        public void SumaNotas()
        {
            int longitud = dataGridViewNotas.RowCount;

            float[] num = new float[longitud];
            float suma = 0;

            for (int i = 0; i < longitud; i++)
            {
                num[i] = float.Parse(dataGridViewNotas.Rows[i].Cells[12].Value.ToString());
            }

            suma = RecursividadSuma(0, num);

            //promedio grado
            MessageBox.Show("El promedio del grado es: " + (suma / longitud).ToString("0.00"), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public float RecursividadSuma(int a, float [] b)
        {
            if (a >= b.Length) return 0;
            else
            {
                return b[a] + RecursividadSuma(a + 1, b);
            }
        }

        //Posicion datagridview
        private void dataGridViewNotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int posicion = dataGridViewNotas.CurrentRow.Index;

            txtCurso.Text = dataGridViewNotas.Rows[posicion].Cells[1].Value.ToString();
            txtPaterno.Text = dataGridViewNotas.Rows[posicion].Cells[2].Value.ToString();
            txtMaterno.Text = dataGridViewNotas.Rows[posicion].Cells[3].Value.ToString();
            txtNombre.Text = dataGridViewNotas.Rows[posicion].Cells[4].Value.ToString();
            txtSeccion.Text = dataGridViewNotas.Rows[posicion].Cells[5].Value.ToString();
            txtDocente.Text = dataGridViewNotas.Rows[posicion].Cells[6].Value.ToString();

            txtExamen1.Text = dataGridViewNotas.Rows[posicion].Cells[8].Value.ToString();
            txtExamen2.Text = dataGridViewNotas.Rows[posicion].Cells[9].Value.ToString();
            txtParcial.Text = dataGridViewNotas.Rows[posicion].Cells[10].Value.ToString();
            txtFinal.Text = dataGridViewNotas.Rows[posicion].Cells[11].Value.ToString();

            float prom = (float.Parse(txtExamen1.Text) * 0.15f) +
                                (float.Parse(txtExamen2.Text) * 0.15f) +
                                (float.Parse(txtParcial.Text) * 0.3f) +
                                (float.Parse(txtFinal.Text) * 0.4f);

            txtPromedio.Text = prom.ToString("0.00");

            txtExamen1.Enabled = true;
            txtExamen2.Enabled = true;
            txtParcial.Enabled = true;
            txtFinal.Enabled = true;
        }

        //No poder escribir en ComboBox
        private void cbOrdenar_KeyPress(object sender, KeyPressEventArgs e)
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

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
    public partial class Estadisticas : Form
    {
        public string ruta = "";

        public Estadisticas(string rutaprincipal)
        {
            InitializeComponent();
            ruta = rutaprincipal;
            tamaño_data();
            TotalAlumnos();

            //habilitar
            txtAprobados.Enabled = false;
            txtDesaprobados.Enabled = false;
            txtTotalAlumnos.Enabled = false;
        }

        //Cambiar tamaños DGV
        public void tamaño_data()
        {
            dataGridViewState.Columns[0].Width = 70;
            dataGridViewState.Columns[2].Width = 80;
            dataGridViewState.Columns[3].Width = 80;
            dataGridViewState.Columns[4].Width = 80;
            dataGridViewState.Columns[5].Width = 55;
            dataGridViewState.Columns[6].Width = 80;
            dataGridViewState.Columns[7].Width = 80;
            dataGridViewState.Columns[8].Width = 80;
            dataGridViewState.Columns[9].Width = 80;
            dataGridViewState.Columns[10].Width = 80;
            dataGridViewState.Columns[11].Width = 80;
            dataGridViewState.Columns[12].Width = 80;
        }

        //Metodo ver registro
        public void DatosRegistrados()
        {
            if (File.Exists(ruta))
            {
                string[] datos = new string[12];
                string registro = "";

                StreamReader leer = File.OpenText(ruta);

                dataGridViewState.Rows.Clear();

                while (!leer.EndOfStream)
                {
                    registro = leer.ReadLine();
                    datos = registro.Split('|');

                    dataGridViewState.Rows.Add(datos[0].Trim(),
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

        //Ver aprobados y cantidad
        private void btnAprobados_Click(object sender, EventArgs e)
        {
            dataGridViewState .Rows.Clear();

            int Aprobados = 0;

            string[] datos = new string[12];
            string registro = "";

            StreamReader leer = File.OpenText(ruta);

            while (!leer.EndOfStream)
            {
                registro = leer.ReadLine();
                datos = registro.Split('|');
                if (float.Parse(datos[12].Trim()) >= 12)
                {
                    Aprobados++;

                    dataGridViewState.Rows.Add(datos[0].Trim(),
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
            }

            leer.Close();
            txtAprobados.Text = Aprobados.ToString();
        }

        //Ver desaprobados y cantidad
        private void btnDesaprobados_Click(object sender, EventArgs e)
        {
            dataGridViewState.Rows.Clear();

            int Desaprobados = 0;

            string[] datos = new string[12];
            string registro = "";

            StreamReader leer = File.OpenText(ruta);

            while (!leer.EndOfStream)
            {
                registro = leer.ReadLine();
                datos = registro.Split('|');
                if (float.Parse(datos[12].Trim()) < 12)
                {
                    Desaprobados++;

                    dataGridViewState.Rows.Add(datos[0].Trim(),
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
            }

            leer.Close();
            txtDesaprobados.Text = Desaprobados.ToString();
        }

        //Cantidad Alumnos
        public void TotalAlumnos()
        {
            string registro = "";
            int contar = 0;

            StreamReader leer = File.OpenText(ruta);

            while (!leer.EndOfStream)
            {
                contar = contar + 1;
                registro = leer.ReadLine();

            }

            leer.Close();

            txtTotalAlumnos.Text = contar.ToString();
        }

        //Ver registro
        private void btnNotas_Click(object sender, EventArgs e)
        {
            DatosRegistrados();
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

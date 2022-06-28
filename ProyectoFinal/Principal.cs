using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Principal : Form
    {

        /* Diseñado y programado por Ameli Diaz Chavez */

        public Principal()
        {
            InitializeComponent();

            panelAbrir.Visible = false;
            btnAbrir.Visible = false;
        }

        public string grado = "";

        //Actualiza grado
        private void btn1ro_Click(object sender, EventArgs e)
        {
            grado = "1ro";

            btnAbrir.Text = "Registro 1ro sec.";
            panelAbrir.Visible = true;
            btnAbrir.Visible = true;
        }
        private void btn2do_Click(object sender, EventArgs e)
        {
            grado = "2do";

            btnAbrir.Text = "Registro 2do sec.";
            panelAbrir.Visible = true;
            btnAbrir.Visible = true;
        }
        private void btn3ro_Click(object sender, EventArgs e)
        {
            grado = "3ro";

            btnAbrir.Text = "Registro 3ro sec.";
            panelAbrir.Visible = true;
            btnAbrir.Visible = true;
        }
        private void btn4to_Click(object sender, EventArgs e)
        {
            grado = "4to";

            btnAbrir.Text = "Registro 4to sec.";
            panelAbrir.Visible = true;
            btnAbrir.Visible = true;
        }
        private void btn5to_Click(object sender, EventArgs e)
        {
            grado = "5to";

            btnAbrir.Text = "Registro 5to sec.";
            panelAbrir.Visible = true;
            btnAbrir.Visible = true;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            panelAbrir.Visible = false;
            btnAbrir.Visible = false;

            string archivo = "";

            if (grado == "1ro")
            {
                archivo = "1ro secundaria.txt";
            }
            else if (grado == "2do")
            {
                archivo = "2do secundaria.txt";
            }
            else if (grado == "3ro")
            {
                archivo = "3ro secundaria.txt";
            }
            else if (grado == "4to")
            {
                archivo = "4to secundaria.txt";
            }
            else if (grado == "5to")
            {
                archivo = "5to secundaria.txt";
            }

            Program.formPrincipal.Hide();

            Opciones formOpciones = new Opciones(archivo);
            formOpciones.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
    }
}

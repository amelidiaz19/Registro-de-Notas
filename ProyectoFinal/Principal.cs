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
        }

        public string archivo = "";

        //Actualiza grado
        private void btn1ro_Click(object sender, EventArgs e)
        {
            archivo = "1ro secundaria.txt";

            Program.formPrincipal.Hide();

            Opciones formOpciones = new Opciones(archivo);
            formOpciones.Show();
        }
        private void btn2do_Click(object sender, EventArgs e)
        {
            archivo = "2do secundaria.txt";

            Program.formPrincipal.Hide();

            Opciones formOpciones = new Opciones(archivo);
            formOpciones.Show();
        }
        private void btn3ro_Click(object sender, EventArgs e)
        {
            archivo = "3ro secundaria.txt";

            Program.formPrincipal.Hide();

            Opciones formOpciones = new Opciones(archivo);
            formOpciones.Show();
        }
        private void btn4to_Click(object sender, EventArgs e)
        {
            archivo = "4to secundaria.txt";

            Program.formPrincipal.Hide();

            Opciones formOpciones = new Opciones(archivo);
            formOpciones.Show();
        }
        private void btn5to_Click(object sender, EventArgs e)
        {
            archivo = "5to secundaria.txt";

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

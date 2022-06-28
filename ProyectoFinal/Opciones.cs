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
    public partial class Opciones : Form
    {
        public string ruta = "";

        public Opciones(string rutaprincipal)
        {
            ruta = rutaprincipal;
            InitializeComponent();
        }

        //Abrir registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Registro FormNotas = new Registro(ruta);
            FormNotas.Show();
            FormNotas.DatosRegistrados();
            FormNotas.Archivo(ruta);
        }

        //Abrir Editar notas
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();

            EditarNotas FormNotas = new EditarNotas(ruta);
            FormNotas.Show();
            FormNotas.DatosRegistrados();
        }

        //Abrir Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();

            Buscar FormBuscar = new Buscar(ruta);
            FormBuscar.Show();
            FormBuscar.DatosRegistrados();
        }

        //Abrir Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Borrar FormBorrar = new Borrar(ruta);
            FormBorrar.Show();
            FormBorrar.DatosRegistrados();
        }

        //Abrir Estadisticas
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
            Estadisticas FormEstadisticas = new Estadisticas(ruta);
            FormEstadisticas.Show();
            FormEstadisticas.DatosRegistrados();
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formPrincipal.Show();
        }
    }
}

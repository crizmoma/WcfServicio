using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Borrar()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client pelicula = new ServiceReference1.Service1Client();
            var Listado = pelicula.CrearPeliculas();
            var lis = pelicula.GetDatosPeliculas(Listado);
            textBox2.Text = lis.Nombre;
            textBox3.Text = (Convert.ToInt32(lis.Clasificación)).ToString();
            textBox4.Text = (Convert.ToInt32(lis.Director)).ToString();
            textBox5.Text = (Convert.ToInt32(lis.Duración)).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Borrar();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
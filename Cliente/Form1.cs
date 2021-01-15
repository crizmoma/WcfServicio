using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
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

            ServiceReference2.Service1Client alumno = new ServiceReference2.Service1Client();
            var Listado = alumno.CrearAlumnos();
            var lis = alumno.GetDatosAlumnos(Listado);
            textBox2.Text = lis.Nombre;
            textBox3.Text = (Convert.ToInt32(lis.NoControl)).ToString();
            textBox4.Text = (Convert.ToInt32(lis.Semestre)).ToString();
            textBox5.Text = (Convert.ToInt32(lis.Promedio)).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Borrar();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service1Client producto = new ServiceReference3.Service1Client();
            object Lista = producto.GetIdProducto();
            _ = producto.GetProducto(Lista);

            textBox2.Text = (Convert.ToInt32(textBox2.Text)).ToString();
            textBox3.Text = (Convert.ToInt32(textBox3.Text)).ToString();
            textBox4.Text = (Convert.ToInt32(textBox4.Text)).ToString();

            MessageBox.Show("Encontrado");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service1Client producto = new ServiceReference3.Service1Client();
            _ = (string)producto.GetData(button3.Text);
         
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias");
        }
    }
}
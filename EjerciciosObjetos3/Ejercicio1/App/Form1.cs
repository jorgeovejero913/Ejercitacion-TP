using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
namespace App
{
    public partial class Form1 : Form
    {
        Calculador calculador = new Calculador();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.Text = calculador.Num.ToString();
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            calculador.Num = float.Parse(num1.Text);

            calculador.sumar();

            resultado.Text = calculador.Acumulado.ToString();

            num1.Text = "";
            history.Text = calculador.Historial;

        }

        private void restar_Click(object sender, EventArgs e)
        {
            calculador.Num = float.Parse(num1.Text);

            calculador.restar();

            resultado.Text = calculador.Acumulado.ToString();

            num1.Text = "";
            history.Text = calculador.Historial ;
        }
    }
}

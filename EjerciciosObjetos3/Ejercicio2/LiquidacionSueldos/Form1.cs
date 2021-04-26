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
namespace LiquidacionSueldos
{
    public partial class Form1 : Form
    {

        Empresa objEmpresa = new Empresa();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objEmpresa.RazonSocial = "Fulanito S.A.";

            objEmpresa.CUIL = "20-123456789-7";



            selectCargos.DataSource = objEmpresa.CargosDisponibles();

            selectCargos.DisplayMember = "Nombre";
        }

        private void aniosAntiguedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void aniosAntiguedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = nombre.Text;
            empleado.AniosAntiguedad = int.Parse(aniosAntiguedad.Text);
            empleado.Apellido = apellido.Text;
            empleado.Cuil = cuil.Text;
            empleado.CantidadHijos = int.Parse(cantidadHijos.Text);

            Cargo objcargo = (Cargo)selectCargos.SelectedValue;
            empleado.Cargo = objcargo;

            liquidacion.Text = objEmpresa.CalcularSueldo(empleado);

        }

        private void cantidadHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

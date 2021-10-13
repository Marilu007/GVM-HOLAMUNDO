using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmHola : Form
    {
        public frmHola()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola " + textBox1.Text + " de PCP 1-1";
            panel1.BackColor = Color.Goldenrod;
            label1.ForeColor = Color.Black;
            textBox1.Focus();
        }

        private void btnAdios_Click(object sender, EventArgs e)
        {
            label1.Text = "Adios " + textBox1.Text + " de PCP 1-1";
            panel1.BackColor = Color.DarkBlue;
            label1.ForeColor = Color.White;
            textBox1.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCap8
{
    public partial class Justificar : Form
    {
        string cad, res = "";
        public Justificar()
        {
            InitializeComponent();
        }

        private void buttonDerecha_Click(object sender, EventArgs e)
        {
            cad = textBoxTexto .Text;

            res = cad.PadRight(40);

            richTextBoxTexto.Text = res;
        }

        private void buttonHizquierda_Click(object sender, EventArgs e)
        {
            cad = textBoxTexto.Text;

            res = cad.PadLeft(40);
            richTextBoxTexto.Text = res;
        }
    }
}

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
    public partial class MuestraCadena : Form
    {
        string palabra;
        public MuestraCadena()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            palabra = textBoxCadena.Text;

            string[] resultado = palabra.Split(new char[] { ',', '.', ';'});

            foreach (string baise in resultado)
            {
               richTextBoxResultado.Text += baise.ToString()+"\n";
            }
        }
    }
}

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
    public partial class MuestraFecha : Form
    {
        String dato;
        
        public MuestraFecha()
        {
            InitializeComponent();
            
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            

            dato  = String.Format("{ 0:hh:mm:ss tt}", DateTime.Now);
            textBoxFecha.Text = dato;
        }
    }
}

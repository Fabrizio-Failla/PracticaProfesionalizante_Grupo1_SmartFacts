using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Facts_Web
{
    public partial class Celulares_Nuevos : Form
    {
        public Celulares_Nuevos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            PedidoN nuevos = new PedidoN();
            nuevos.Show();
            this.Hide();

        }
    }
}

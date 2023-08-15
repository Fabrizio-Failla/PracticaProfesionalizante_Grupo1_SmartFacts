using Clases_Smart_Facts;
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
    public partial class Registracion : Form
    {
        Principal principal = new Principal();
        public Registracion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres volver al menú principal? Se perderán todos tus datos si no creaste una cuenta.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Close();
            }
            else
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea un nuevo cliente con los datos ingresados
            Cliente clienteNuevo = new Cliente();
            clienteNuevo.email_cliente = txtUsuario.Text;
            
            clienteNuevo.contrasenia_persona = txtContra.Text;
            principal.AltaCliente(clienteNuevo);
            MessageBox.Show("Felicidades, creaste tu cuenta de Smart Facts");
            txtUsuario.Text = "";
            txtContra.Text = "";

            
          
        }
    }
}

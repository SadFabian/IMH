using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_interactivo
{
    public partial class Pantalla_principal : Form
    {
        public Pantalla_principal()
        {
            InitializeComponent();
        }

        private void image_logo_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_principal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle =FormBorderStyle.Fixed3D;
            this.ControlBox = true;
            
            this.MinimizeBox = true;
            this.MaximizeBox = false;

            this.Text = "GOPLAY";
            this.BackColor = Color.FromArgb(204, 255, 153);

            this.buttonRegistro.Text = "Registrate";
            this.buttonIngresa.Text = "Ingresar";
           

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresa_Click(object sender, EventArgs e)
        {

        }

       
        private void Pantalla_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar PLAYGO?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Pantalla_principal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

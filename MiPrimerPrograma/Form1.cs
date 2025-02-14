using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau..");
        }

        private void btnPractica_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atencion");
            //this.BackColor = Color.Pink;
            if (tbPrueba.Text == "")
            {
                tbPrueba.BackColor = Color.Red;
            }
            else
            {
                tbPrueba.BackColor = System.Drawing.SystemColors.Control;
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Preciono el boton izquierdo", "Atencion.");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Preciono el boton derecho", "Atencion.");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Preciono el boton del medio", "Atencion.");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.OrangeRed;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = Color.Blue;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void tbPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbPrueba2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tbPrueba2.Text.Length + "Caracteres.");
        }

    }
}

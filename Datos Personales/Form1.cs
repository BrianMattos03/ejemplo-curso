using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Personales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<TextBox> tbxlista = new List<TextBox>();
            tbxlista.Add(tbApellido);
            tbxlista.Add(tbNombre);
            tbxlista.Add(tbEdad);
            tbxlista.Add(tbDireccion);
            bool valid = false;
            short con = 0;
            // Recorremos la lista del TextBox
            foreach (TextBox tbx in tbxlista)
            {
                if (tbx.Text != "")
                    con++;
                else
                    valid = false;
            }
            // Validamos si todas las casillas tienen contenido
            if (con == 4)
                valid = true;
            //
            if (valid)
                tbResultado.Text = "Apellido y Nombre: " + tbApellido.Text + ',' + tbNombre.Text + Environment.NewLine +"Edad: " + tbEdad.Text + Environment.NewLine + "Direccion: " + tbDireccion.Text;
            else
                tbResultado.Text = "ALGUN CAMPO ESTA INCOMPLETO.";

        }

        private void tbApellido_Validating(object sender, CancelEventArgs e)
        {
            if (tbApellido.Text == "")
                tbApellido.BackColor = Color.Red;
            else
                tbApellido.BackColor = Color.White;
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tbNombre.Text == "")
                tbNombre.BackColor = Color.Red;
            else
                tbNombre.BackColor = Color.White;
        }

        private void tbEdad_Validating(object sender, CancelEventArgs e)
        {
            if (tbEdad.Text == "")
                tbEdad.BackColor = Color.Red;
            else
                tbEdad.BackColor = Color.White;
        }

        private void tbDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (tbDireccion.Text == "")
                tbDireccion.BackColor = Color.Red;
            else
                tbDireccion.BackColor = Color.White;
        }

       
            
        

        
    }
}

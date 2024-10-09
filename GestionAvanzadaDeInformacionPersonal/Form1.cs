using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAvanzadaDeInformacionPersonal
{
    public partial class Form1 : Form
    {            
        Datos datos = new Datos();
        String foto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerHora.Start();
            tabControlPrincipal.SelectedIndex = 0;
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = "Hora: "+ DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (abrirFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                foto = abrirFotoPerfil.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text.Length == 0 ||
                tbxDireccion.Text.Length == 0 ||
                tbxCorreo.Text.Length == 0 ||
                (!rbtFem.Checked && !rbtMasc.Checked && !rbtOtro.Checked) ||
                nudEdad.Value == 0 ||
                combPais.SelectedItem == null ||
                clbHobbies.CheckedItems.Count == 0
                )
            {
                MessageBox.Show("Error: Faltan campos por introducir");
            }
            else if ((DateTime.Today - mcalFechaNac.SelectionStart).Days/365 != nudEdad.Value )
            {
                MessageBox.Show("Error: La fecha de nacimiento no coincide con la edad especificada");
            }
            else
            {
                datos.Nombre = tbxNombre.Text;
                lbDatosNombre.Text = "Nombre: " + tbxNombre.Text;

                datos.Direccion = tbxDireccion.Text;
                lbDatosDireccion.Text = "Dirección: " + tbxDireccion.Text;

                datos.Email = tbxCorreo.Text;
                lbDatosEmail.Text = "E-mail: " + tbxCorreo.Text;

                if (rbtMasc.Checked) datos.Genero = rbtMasc.Text;
                if (rbtFem.Checked) datos.Genero = rbtFem.Text;
                if (rbtOtro.Checked) datos.Genero = rbtOtro.Text;
                lbDatosGenero.Text = "Género: " + datos.Genero;

                datos.Edad = (int)nudEdad.Value;
                lbDatosEdad.Text = "Edad: " + datos.Edad.ToString();

                datos.FechaNac = mcalFechaNac.SelectionStart;
                lbDatosFechaNac.Text = "Fecha de nacimiento: " + mcalFechaNac.SelectionStart.ToShortDateString();

                datos.Pais = combPais.SelectedItem.ToString();
                lbDatosPais.Text = datos.Pais;

                ArrayList hobbies = new ArrayList();
                foreach (var item in clbHobbies.CheckedItems)
                {
                    hobbies.Add(item.ToString());
                }
                datos.Hobbies = hobbies;
                lbDatosHobbies.Text = "Hobbies: ";
                foreach (var item in hobbies)
                {
                    lbDatosHobbies.Text += "\n -" + item;
                }

                datos.Subscripcion = cbxSuscribir.Checked;
                if (cbxSuscribir.Checked) lbDatosSuscripcion.Text = "Subscripción: Si";
                else lbDatosSuscripcion.Text = "Subscripción: No";

                datos.NivelSatisfacción = trbSatisfaccion.Value;
                
                if (foto != null) pbxFoto.Image = Image.FromFile(foto);
                datos.RutaFotoPerfil = pbxFoto.ImageLocation;

                tabControlPrincipal.SelectedIndex = 2;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
            tbxDireccion.Clear();
            tbxCorreo.Clear();
            rbtFem.Checked = false;
            rbtMasc.Checked = false;
            rbtOtro.Checked = false;
            nudEdad.Value = 0;
            mcalFechaNac.SelectionStart = DateTime.Now;
            combPais.SelectedIndex = -1;
            cbxSuscribir.Checked = false;
            clbHobbies.ClearSelected();
            for (int i = 0;i<  clbHobbies.Items.Count;i++)
            {
                clbHobbies.SetItemChecked(i, false);
            }
            trbSatisfaccion.Value = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trbSatisfaccion_Scroll(object sender, EventArgs e)
        {
            lbNumSatisfaccion.Text = trbSatisfaccion.Value.ToString();
        }
    }
}

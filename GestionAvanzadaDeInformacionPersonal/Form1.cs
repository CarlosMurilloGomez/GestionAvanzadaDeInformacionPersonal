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
                pbxFoto.Image = Image.FromFile(abrirFotoPerfil.FileName);
            }
        }
    }
}

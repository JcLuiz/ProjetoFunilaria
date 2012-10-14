using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Funilaria
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            // Entra no formulario principal
            if (txtBoxUsuario.Text == "teste" && txtSenha.Text == "teste")
            {
                TelaPrincipal frm = new TelaPrincipal();
                frm.ShowDialog();
                //this.Visible = false;
                this.Close();
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

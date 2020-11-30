using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class frmLogin : Form
    {
        public object UsuarioLogado { get; internal set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string nome = txtNome.Text;
            try
            {
                var context = new DatabaseEntities();
                tbAtendente atendente = context.tbAtendente.First(p => p.login == nome && p.senha == senha);
                if (atendente != null)
                {
                    Properties.Settings.Default.usuario = atendente.nome;
                    Properties.Settings.Default.Save();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception)
            {
                frmMensagem mensagem = new frmMensagem();
                mensagem.mensagem = "Erro login";
                mensagem.ShowDialog();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           


        }
    }


}
    


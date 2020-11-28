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
    public partial class frmAtendente : Form
    {
        public frmAtendente()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var context = new DatabaseEntities();
            if (txtCodigo.Text == "")
            {

                var atendente = new tbAtendente()
                {
                    nome = txtNome.Text,
                    telefone = txtTelefone.Text,
                    cpf = txtCPF.Text,
                    endereco = txtEndereco.Text,
                    cep = txtCep.Text,
                    cidade = txtCidade.Text,
                    estado = txtEstado.Text,
                    login=txtLogin.Text,
                    senha=txtSenha.Text
                };
                context.tbAtendente.Add(atendente);
                context.SaveChanges();

                mensagem = new frmMensagem
                {
                    mensagem = "Salvar"
                };
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                tbAtendente atendente = context.tbAtendente.First(p => p.idAtendente == codigo);

                atendente.nome = txtNome.Text;
                atendente.telefone = txtTelefone.Text;
                atendente.cpf = txtCPF.Text;
                atendente.endereco = txtEndereco.Text;
                atendente.cep = txtCep.Text;
                atendente.cidade = txtCidade.Text;
                atendente.estado = txtEstado.Text;
                atendente.senha = txtSenha.Text;
                atendente.login = txtLogin.Text;

                context.SaveChanges();
                frmMensagem frmMensagem = new frmMensagem();
                mensagem = frmMensagem;
                mensagem.mensagem = "Atualizar";
            }
            limpar();
            mensagem.Show();
            dtgAtendente.DataSource = Todos;
        }

        private void limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                var context = new DatabaseEntities();
                int codigo = Convert.ToInt32(txtCodigo.Text);
                tbAtendente atendente = context.tbAtendente.First(p => p.idAtendente == codigo);

                context.tbAtendente.Attach(atendente);
                context.Set<tbAtendente>().Remove(atendente);
                context.SaveChanges();
            }
            mensagem = new frmMensagem
            {
                mensagem = "Excluir"
            };
            dtgAtendente.DataSource = Todos;
            limpar();
            mensagem.Show();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            dtgAtendente.DataSource = Todos;
        }
        public virtual List<tbAtendente> Todos
        {
            get
            {
                var context = new DatabaseEntities();
                return context.tbAtendente.ToList();
            }
        }

        private void dtgAtendente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgAtendente.Rows[e.RowIndex].Cells["idAtendente"].Value.ToString();
            txtNome.Text = dtgAtendente.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtTelefone.Text = dtgAtendente.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            txtCPF.Text = dtgAtendente.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
            txtEndereco.Text = dtgAtendente.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
            txtCep.Text = dtgAtendente.Rows[e.RowIndex].Cells["Cep"].Value.ToString();
            txtCidade.Text = dtgAtendente.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
            txtEstado.Text = dtgAtendente.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            txtLogin.Text = dtgAtendente.Rows[e.RowIndex].Cells["login"].Value.ToString();
            txtSenha.Text = dtgAtendente.Rows[e.RowIndex].Cells["senha"].Value.ToString();

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCPF.TextLength == 11)
                {
                    long CPF = Convert.ToInt64(txtCPF.Text);
                    string CPFFormatado = String.Format(@"{0:\000\.000\.000\-00}", CPF);
                    txtCPF.Text = CPFFormatado;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

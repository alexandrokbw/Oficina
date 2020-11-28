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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var context = new DatabaseEntities();
            if (txtCodigo.Text == "")
            {

                var fornecedor = new tbFornecedor()
                {
                    nome = txtNome.Text,
                    telefone = txtTelefone.Text,
                    cnpj = txtCnpj.Text,
                    endereco = txtEndereco.Text,
                    cep = txtCep.Text,
                    cidade = txtCidade.Text,
                    estado = txtEstado.Text
                };
                context.tbFornecedor.Add(fornecedor);
                context.SaveChanges();

                mensagem = new frmMensagem
                {
                    mensagem = "Salvar"
                };
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                tbFornecedor fornecedor = context.tbFornecedor.First(p => p.idFornecedor== codigo);

                fornecedor.nome = txtNome.Text;
                fornecedor.telefone = txtTelefone.Text;
                fornecedor.cnpj = txtCnpj.Text;
                fornecedor.endereco = txtEndereco.Text;
                fornecedor.cep = txtCep.Text;
                fornecedor.cidade = txtCidade.Text;
                fornecedor.estado = txtEstado.Text;

                context.SaveChanges();
                frmMensagem frmMensagem = new frmMensagem();
                mensagem = frmMensagem;
                mensagem.mensagem = "Atualizar";
            }
            limpar();
            mensagem.Show();
            dtgFornecedor.DataSource = Todos;
        }

        private void limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCnpj.Clear();
            txtEndereco.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                var context = new DatabaseEntities();
                int codigo = Convert.ToInt32(txtCodigo.Text);
                tbFornecedor Fornecedor = context.tbFornecedor.First(p => p.idFornecedor == codigo);

                context.tbFornecedor.Attach(Fornecedor);
                context.Set<tbFornecedor>().Remove(Fornecedor);
                context.SaveChanges();
            }
            mensagem = new frmMensagem
            {
                mensagem = "Excluir"
            };
            dtgFornecedor.DataSource = Todos;
            limpar();
            mensagem.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            dtgFornecedor.DataSource = Todos;
        }
        public virtual List<tbFornecedor> Todos
        {
            get
            {
                var context = new DatabaseEntities();
                return context.tbFornecedor.ToList();
            }
        }

        private void dtgFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgFornecedor.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString();
            txtNome.Text = dtgFornecedor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtTelefone.Text = dtgFornecedor.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            txtCnpj.Text = dtgFornecedor.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtEndereco.Text = dtgFornecedor.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
            txtCep.Text = dtgFornecedor.Rows[e.RowIndex].Cells["Cep"].Value.ToString();
            txtCidade.Text = dtgFornecedor.Rows[e.RowIndex].Cells["Cidade"].Value.ToString();
            txtEstado.Text = dtgFornecedor.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        }
    }
}

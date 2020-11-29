using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            listarProduto();
            listaFornecedor.DataSource = Todos;
            listaFornecedor.ValueMember = "idFornecedor";
            listaFornecedor.DisplayMember = "nome";

        }

        public virtual List<tbFornecedor> Todos
        {
            get
            {
                var context = new DatabaseEntities();
                return context.tbFornecedor.ToList();
            }
        
        }

        private void listarProduto()
        {
                DatabaseEntities dataBase = new DatabaseEntities();
                var dt = from Fornecedor in dataBase.tbFornecedor
                         join Produto in dataBase.tbProduto 
                         on Fornecedor.idFornecedor equals Produto.idFornecedor
                select new
                {
                    Fornecedor.idFornecedor,
                    Fornecedor.nome,
                    Produto.idProduto,
                    Produto.codigo,
                    Produto.descricao,
                    Produto.precoCusto,
                    Produto.precoVenda,
                    Produto.estoque,
                    Produto.estoqueMinimo,
                    Produto.tipo,
                };
                dtgProduto.DataSource = dt.ToList();
        }

        private void dtgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgProduto.Rows[e.RowIndex].Cells["idProduto"].Value.ToString();
            txtCodigoFor.Text = dtgProduto.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString();
            txtDescricao.Text = dtgProduto.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtCodigoBarras.Text = dtgProduto.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtEstoqueAtual.Text = dtgProduto.Rows[e.RowIndex].Cells["estoque"].Value.ToString();
            txtPrecoCusto.Text = dtgProduto.Rows[e.RowIndex].Cells["precoCusto"].Value.ToString();
            txtPrecoVenda.Text = dtgProduto.Rows[e.RowIndex].Cells["precoVenda"].Value.ToString();
            txtEstoqueMinimo.Text = dtgProduto.Rows[e.RowIndex].Cells["estoqueMinimo"].Value.ToString();
            txtEstoqueMinimo.Text = dtgProduto.Rows[e.RowIndex].Cells["estoqueMinimo"].Value.ToString();
            txtTipo.Text = dtgProduto.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var context = new DatabaseEntities();
            if (txtCodigo.Text == "")
            {
                var produto = new tbProduto()
                {
                idFornecedor = Convert.ToInt32(txtCodigoFor.Text),
                codigo = txtCodigoBarras.Text,
                descricao = txtDescricao.Text,
                precoCusto = Convert.ToDecimal(txtPrecoCusto.Text),
                precoVenda = Convert.ToDecimal(txtPrecoVenda.Text),
                estoqueMinimo = txtEstoqueMinimo.Text,
                estoque = txtEstoqueAtual.Text,
                tipo = txtTipo.Text,
            };
                context.tbProduto.Add(produto);
                context.SaveChanges();

                mensagem = new frmMensagem
                {
                    mensagem = "Salvar"
                };
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                tbProduto produto = context.tbProduto.First(p => p.idProduto == codigo);
                produto.idProduto = codigo;
                produto.idFornecedor = Convert.ToInt32(txtCodigoFor.Text);
                produto.codigo = txtCodigoBarras.Text;
                produto.descricao = txtDescricao.Text;
                produto.precoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                produto.precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                produto.estoqueMinimo = txtEstoqueMinimo.Text;
                produto.estoque = txtEstoqueAtual.Text;
                produto.tipo = txtTipo.Text;

        context.SaveChanges();
                mensagem = new frmMensagem
                {
                    mensagem = "Atualizar"
                };
            }
            limpar();
            mensagem.Show();
            listarProduto();

        }

        private void limpar()
        {
            txtCodigo.Clear();
            txtCodigoFor.Clear();
            txtDescricao.Clear();
            txtCodigoBarras.Clear();
            txtEstoqueAtual.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            txtEstoqueMinimo.Clear();
            txtEstoqueMinimo.Clear();
            txtTipo.Text="";
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoFor.Text = listaFornecedor.SelectedValue.ToString();
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

                tbProduto produto = context.tbProduto.First(p => p.idProduto == codigo);

                context.tbProduto.Attach(produto);
                context.Set<tbProduto>().Remove(produto);
                context.SaveChanges();
            }
            mensagem = new frmMensagem
            {
                mensagem = "Excluir"
            };
            listarProduto();
            limpar();
            mensagem.Show();

        }
    }
}

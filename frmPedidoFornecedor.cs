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
    public partial class frmPedidoFornecedor : Form
    {
        public frmPedidoFornecedor()
        {
            InitializeComponent();
        }
        frmMensagem mensagem;
        private int idProduto;
        private void frmPedidoFornecedor_Load(object sender, EventArgs e)
        {
            listarPedidoAguardando();
            lblUsusario.Text = $"Usuario: {Properties.Settings.Default.usuario}";
        }

        private void listarPedidoAguardando()
        {
            DatabaseEntities dataBase = new DatabaseEntities();
            var dt = from pedidoFor in dataBase.tbPedidoFornecedor
                     join Fornecedor in dataBase.tbFornecedor on pedidoFor.idFornecedor equals Fornecedor.idFornecedor
                     join produto in dataBase.tbProduto on pedidoFor.idProduto equals produto.idProduto
                     select new
                     {
                         
                         Npedido = pedidoFor.idPedidoFornecedor,
                         produto.idProduto,
                         produto.codigo,
                         produto.descricao,
                         pedidoFor.idFornecedor,
                         Fornecedor = Fornecedor.nome,
                         produto.precoCusto,
                         produto.precoVenda,
                         //produto.estoque,
                         produto.estoqueMinimo,
                         produto.tipo,
                         pedidoFor.quantidade,
                         pedidoFor.stausPedido,
                         pedidoFor.dataRecebiemnto,
                         pedidoFor.dataSolicitacao,
                         pedidoFor.usuario
                     };
            dtgPedido.DataSource = dt.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto forProduto = new frmProduto();
            if (forProduto.ShowDialog() == DialogResult.OK)
            {
                lblCodigoProduto.Text =$"Código: {forProduto.codigoBarras}";
                lblDescricao.Text = $"Descrição: {forProduto.descricaoProduto}";
                lblFornecedor.Text = $"Fornecedor: {forProduto.nomefornecedor}";
                lblTipo.Text = $"Tipo: {forProduto.tipo}";
                lblIdFornecedor.Text = forProduto._idFornecedor;
                idProduto = Convert.ToInt32(forProduto._idProduto);
            }
        }

        private void txtCodigoPedidoFor_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoPedidoFor.Text=="")
            {
                txtDataRecebimento.Enabled = false;
            }
            else
            {
                txtDataRecebimento.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var context = new DatabaseEntities();
            if (txtCodigoPedidoFor.Text == "")
            {
                var pedidoFor = new tbPedidoFornecedor()
                {
                    idFornecedor = Convert.ToInt32(lblIdFornecedor.Text),
                    idProduto = idProduto,
                    usuario = Properties.Settings.Default.usuario,
                    dataSolicitacao = txtDataPedido.Text,
                    quantidade = txtQuantidade.Text,
                    stausPedido = "Aguardando", 
                };
                context.tbPedidoFornecedor.Add(pedidoFor);
                context.SaveChanges();
                mensagem = new frmMensagem
                {
                    mensagem = "Salvar"
                };
            }
            else
            {
                int codigo = Convert.ToInt32(txtCodigoPedidoFor.Text);
                tbPedidoFornecedor PedidoFor = context.tbPedidoFornecedor.First(p => p.idPedidoFornecedor == codigo);
                PedidoFor.idProduto = idProduto;
                PedidoFor.idFornecedor = Convert.ToInt32(lblIdFornecedor.Text);
                PedidoFor.quantidade = txtQuantidade.Text;
                PedidoFor.dataSolicitacao = txtDataPedido.Text;

                context.SaveChanges();
                mensagem = new frmMensagem
                {
                    mensagem = "Atualizar"
                };
            }
            limpar();
            mensagem.Show();
            listarPedidoAguardando();

        }

        private void dtgPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPedidoFor.Text = dtgPedido.Rows[e.RowIndex].Cells["Npedido"].Value.ToString();
            lblIdFornecedor.Text= dtgPedido.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString();
            idProduto= Convert.ToInt32(dtgPedido.Rows[e.RowIndex].Cells["idProdutoPedido"].Value);
            txtQuantidade.Text= dtgPedido.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
            txtDataPedido.Text= dtgPedido.Rows[e.RowIndex].Cells["dataSolicitacao"].Value.ToString();

            lblCodigoProduto.Text = $"Código: {dtgPedido.Rows[e.RowIndex].Cells["codigo"].Value.ToString()}";
            lblDescricao.Text = $"Descrição: {dtgPedido.Rows[e.RowIndex].Cells["descricao"].Value.ToString()}";
            lblFornecedor.Text = $"Fornecedor: {dtgPedido.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString()}";
            lblTipo.Text = $"Tipo: {dtgPedido.Rows[e.RowIndex].Cells["tipo"].Value.ToString()}";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtCodigoPedidoFor.Clear();
            txtQuantidade.Clear();
            lblCodigoProduto.Text = "";
            lblDescricao.Text = "";
            lblFornecedor.Text = "";
            lblIdFornecedor.Text = "";
            lblTipo.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoPedidoFor.Text != "")
            {
                var context = new DatabaseEntities();
                int codigo = Convert.ToInt32(txtCodigoPedidoFor.Text);
                tbPedidoFornecedor pedidoFornecedor = context.tbPedidoFornecedor.First(p => p.idPedidoFornecedor == codigo);

                context.tbPedidoFornecedor.Attach(pedidoFornecedor);
                context.Set<tbPedidoFornecedor>().Remove(pedidoFornecedor);
                context.SaveChanges();
            }
            mensagem = new frmMensagem
            {
                mensagem = "Excluir"
            };
            listarPedidoAguardando();
            limpar();
            mensagem.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Valoe alterado");
        }
    }
}

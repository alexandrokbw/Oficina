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

        private void frmPedidoFornecedor_Load(object sender, EventArgs e)
        {
            listarPedidoAguardando();
        }

        private void listarPedidoAguardando()
        {
            DatabaseEntities dataBase = new DatabaseEntities();
            var dt = from pedidoFor in dataBase.tbPedidoFornecedor
                     join Fornecedor in dataBase.tbFornecedor on pedidoFor.idFornecedor equals Fornecedor.idFornecedor
                     join produto in dataBase.tbProduto on pedidoFor.idProduto equals produto.idProduto
                     select new
                     {
                         pedidoFor.idFornecedor,
                         Fornecedor = Fornecedor.nome,
                         produto.idProduto,
                         produto.codigo,
                         produto.descricao,
                         produto.precoCusto,
                         produto.precoVenda,
                         produto.estoque,
                         produto.estoqueMinimo,
                         produto.tipo,
                         pedidoFor.quantidiade,
                         pedidoFor.stausPedido,
                         //pedidoFor.dataRecebiemnto,
                         pedidoFor.dataSolicitacao,
                         pedidoFor.usuario
                     };
            dtgPedido.DataSource = dt.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

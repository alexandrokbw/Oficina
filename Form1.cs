﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _idProduto;
        private int idCliente;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente clientes = new frmCliente();
            clientes.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.ShowDialog();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPedidoFor_Click(object sender, EventArgs e)
        {
            frmPedidoFornecedor pedidoFor = new frmPedidoFornecedor();
            pedidoFor.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { 


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolherProduto_Click(object sender, EventArgs e)
        {
            frmProduto forProduto = new frmProduto();
            if (forProduto.ShowDialog() == DialogResult.OK)
            {
                DatabaseEntities dataBase = new DatabaseEntities();
                
                    lblCodigoProduto.Text = $"Código: {dt.codigoBarras}";
                    lblDescricao.Text = $"Descrição: {forProduto.descricaoProduto}";
                    lblFornecedor.Text = $"Fornecedor: {forProduto.nomefornecedor}";
                    lblTipo.Text = $"Tipo: {forProduto.tipo}";
                    _idProduto = Convert.ToInt32(forProduto._idProduto);
                    lblPrecoVenda.Text = $"Venda: {forProduto.precoVenda}";
                    lblPrecoCusto.Text = $"Custo: {forProduto.precoCusto}";
                    lblEstoque.Text = $"Estoque: {forProduto.estoque}";
            }
        }
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmCliente forCliente = new frmCliente();
            if (forCliente.ShowDialog() == DialogResult.OK)
            {
                //Produto.Add(forCliente._idCliente);
                idCliente = forCliente._idCliente;
                lblNome.Text=$"Nome: {forCliente.nome}";
                lblTelefone.Text=$"Telefone: {forCliente.telefone}";
                lblCpf.Text=$"CPF: {forCliente.cpf}";
                lblEndereco.Text=$"Endereco: {forCliente.endereco}";
                lblCep.Text=$"CEP: {forCliente.cep}";
                lblCidade.Text=$"Cidade: {forCliente.cidade}";
                lblEstado.Text= $"Estado: {forCliente.estado}";
            }
        }
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            frmFimPedido fimPedido = new frmFimPedido();
            fimPedido.ShowDialog();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
                dtgPedidoCliente.Rows.Add();
                int index = dtgPedidoCliente.Rows.Count-1;
                dtgPedidoCliente.Rows[index].Cells["Codigo"].Value = "a";
                dtgPedidoCliente.Rows[index].Cells["Descricao"].Value = "b";
                dtgPedidoCliente.Rows[index].Cells["Estoque"].Value = "c";
                dtgPedidoCliente.Rows[index].Cells["Valor"].Value = "d";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dtgPedidoCliente.Rows.RemoveAt(dtgPedidoCliente.CurrentRow.Index);
        }
    }
}


namespace Oficina
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNPedido = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEscolherProduto = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.dtgPedidoCliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPedidoFor = new System.Windows.Forms.Label();
            this.btnProduto = new System.Windows.Forms.Label();
            this.btnAtendente = new System.Windows.Forms.Label();
            this.btnFornecedor = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Label();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 489);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bunifuCustomDataGrid2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(12, 324);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1028, 133);
            this.bunifuCustomDataGrid2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblEstoque);
            this.groupBox2.Controls.Add(this.lblPrecoCusto);
            this.groupBox2.Controls.Add(this.lblPrecoVenda);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.lblDescricao);
            this.groupBox2.Controls.Add(this.lblFornecedor);
            this.groupBox2.Controls.Add(this.lblCodigoProduto);
            this.groupBox2.Controls.Add(this.dtgPedidoCliente);
            this.groupBox2.Location = new System.Drawing.Point(5, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNPedido);
            this.groupBox3.Controls.Add(this.lblValor);
            this.groupBox3.Controls.Add(this.btnRemover);
            this.groupBox3.Controls.Add(this.btnEscolherProduto);
            this.groupBox3.Controls.Add(this.btnSalvarPedido);
            this.groupBox3.Controls.Add(this.btnAddProduto);
            this.groupBox3.Location = new System.Drawing.Point(777, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 192);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // lblNPedido
            // 
            this.lblNPedido.AutoSize = true;
            this.lblNPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPedido.Location = new System.Drawing.Point(10, 16);
            this.lblNPedido.Name = "lblNPedido";
            this.lblNPedido.Size = new System.Drawing.Size(90, 18);
            this.lblNPedido.TabIndex = 10;
            this.lblNPedido.Text = "N° Pedido:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(10, 54);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(55, 18);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor:";
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(140, 90);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(112, 32);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEscolherProduto
            // 
            this.btnEscolherProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherProduto.Location = new System.Drawing.Point(7, 90);
            this.btnEscolherProduto.Name = "btnEscolherProduto";
            this.btnEscolherProduto.Size = new System.Drawing.Size(112, 32);
            this.btnEscolherProduto.TabIndex = 1;
            this.btnEscolherProduto.Text = "Produto";
            this.btnEscolherProduto.UseVisualStyleBackColor = true;
            this.btnEscolherProduto.Click += new System.EventHandler(this.btnEscolherProduto_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPedido.Location = new System.Drawing.Point(140, 139);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(112, 32);
            this.btnSalvarPedido.TabIndex = 10;
            this.btnSalvarPedido.Text = "Finalizar pedido";
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Location = new System.Drawing.Point(8, 139);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(112, 32);
            this.btnAddProduto.TabIndex = 9;
            this.btnAddProduto.Text = "Add";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(676, 56);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(31, 13);
            this.lblEstoque.TabIndex = 13;
            this.lblEstoque.Text = "Tipo:";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(676, 36);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(31, 13);
            this.lblPrecoCusto.TabIndex = 12;
            this.lblPrecoCusto.Text = "Tipo:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(676, 16);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(31, 13);
            this.lblPrecoVenda.TabIndex = 11;
            this.lblPrecoVenda.Text = "Tipo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(369, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 47);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(369, 47);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(8, 21);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProduto.TabIndex = 2;
            this.lblCodigoProduto.Text = "Código:";
            // 
            // dtgPedidoCliente
            // 
            this.dtgPedidoCliente.AllowUserToAddRows = false;
            this.dtgPedidoCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgPedidoCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPedidoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidoCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgPedidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPedidoCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPedidoCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPedidoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.Codigo,
            this.Descricao,
            this.Estoque,
            this.Valor});
            this.dtgPedidoCliente.DoubleBuffered = true;
            this.dtgPedidoCliente.EnableHeadersVisualStyles = false;
            this.dtgPedidoCliente.HeaderBgColor = System.Drawing.Color.Teal;
            this.dtgPedidoCliente.HeaderForeColor = System.Drawing.Color.White;
            this.dtgPedidoCliente.Location = new System.Drawing.Point(6, 72);
            this.dtgPedidoCliente.Name = "dtgPedidoCliente";
            this.dtgPedidoCliente.ReadOnly = true;
            this.dtgPedidoCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgPedidoCliente.Size = new System.Drawing.Size(767, 138);
            this.dtgPedidoCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnAddCliente);
            this.groupBox1.Controls.Add(this.cboVeiculo);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(823, 41);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 9;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(487, 60);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(487, 10);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Veiculo:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(613, 35);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(487, 35);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 8;
            this.lblCep.Text = "CEP:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(160, 59);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(160, 34);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(160, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(9, 49);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "Add Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(754, 56);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(278, 21);
            this.cboVeiculo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnPedidoFor);
            this.bunifuGradientPanel1.Controls.Add(this.btnProduto);
            this.bunifuGradientPanel1.Controls.Add(this.btnAtendente);
            this.bunifuGradientPanel1.Controls.Add(this.btnFornecedor);
            this.bunifuGradientPanel1.Controls.Add(this.btnClientes);
            this.bunifuGradientPanel1.Controls.Add(this.btnSair);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1060, 43);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnPedidoFor
            // 
            this.btnPedidoFor.AutoSize = true;
            this.btnPedidoFor.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidoFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoFor.Location = new System.Drawing.Point(292, 17);
            this.btnPedidoFor.Name = "btnPedidoFor";
            this.btnPedidoFor.Size = new System.Drawing.Size(137, 16);
            this.btnPedidoFor.TabIndex = 5;
            this.btnPedidoFor.Text = "Pedido fornecedor";
            this.btnPedidoFor.Click += new System.EventHandler(this.btnPedidoFor_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.AutoSize = true;
            this.btnProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(601, 17);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(62, 16);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Produto";
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnAtendente
            // 
            this.btnAtendente.AutoSize = true;
            this.btnAtendente.BackColor = System.Drawing.Color.Transparent;
            this.btnAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendente.Location = new System.Drawing.Point(476, 17);
            this.btnAtendente.Name = "btnAtendente";
            this.btnAtendente.Size = new System.Drawing.Size(78, 16);
            this.btnAtendente.TabIndex = 3;
            this.btnAtendente.Text = "Atendente";
            this.btnAtendente.Click += new System.EventHandler(this.btnAtendente_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.AutoSize = true;
            this.btnFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(710, 17);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(88, 16);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(845, 17);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(64, 16);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(955, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 16);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label btnSair;
        private System.Windows.Forms.Label btnClientes;
        private System.Windows.Forms.Label btnFornecedor;
        private System.Windows.Forms.Label btnProduto;
        private System.Windows.Forms.Label btnAtendente;
        private System.Windows.Forms.Label btnPedidoFor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgPedidoCliente;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.Button btnEscolherProduto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Label lblNPedido;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}


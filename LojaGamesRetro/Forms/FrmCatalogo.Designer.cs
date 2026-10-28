namespace LojaGamesRetro.Forms
{
    partial class FrmCatalogo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            btnVoltar = new Button();
            cboPlataforma = new ComboBox();
            txtBusca = new TextBox();
            lblTitulo = new Label();
            pnlCarrinho = new Panel();
            btnLimpar = new Button();
            btnFinalizar = new Button();
            lblTotal = new Label();
            cboPagamento = new ComboBox();
            lblPagamento = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            btnRemover = new Button();
            lvCarrinho = new ListView();
            colJogo = new ColumnHeader();
            colQtd = new ColumnHeader();
            colSubtotal = new ColumnHeader();
            lblCarrinho = new Label();
            flpCards = new FlowLayoutPanel();
            pnlTopo.SuspendLayout();
            pnlCarrinho.SuspendLayout();
            SuspendLayout();
            //
            // pnlTopo
            //
            pnlTopo.BackColor = Color.FromArgb(38, 32, 58);
            pnlTopo.Controls.Add(btnVoltar);
            pnlTopo.Controls.Add(cboPlataforma);
            pnlTopo.Controls.Add(txtBusca);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1200, 70);
            pnlTopo.TabIndex = 0;
            //
            // btnVoltar
            //
            btnVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVoltar.Location = new Point(1060, 18);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 34);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "← VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            //
            // cboPlataforma
            //
            cboPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlataforma.Font = new Font("Segoe UI", 11F);
            cboPlataforma.Location = new Point(620, 21);
            cboPlataforma.Name = "cboPlataforma";
            cboPlataforma.Size = new Size(200, 28);
            cboPlataforma.TabIndex = 2;
            cboPlataforma.SelectedIndexChanged += Filtro_Changed;
            //
            // txtBusca
            //
            txtBusca.Font = new Font("Segoe UI", 11F);
            txtBusca.Location = new Point(390, 21);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar jogo...";
            txtBusca.Size = new Size(215, 27);
            txtBusca.TabIndex = 1;
            txtBusca.TextChanged += Filtro_Changed;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 229, 255);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(338, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎮 CATÁLOGO DE JOGOS";
            //
            // pnlCarrinho
            //
            pnlCarrinho.BackColor = Color.FromArgb(38, 32, 58);
            pnlCarrinho.Controls.Add(btnLimpar);
            pnlCarrinho.Controls.Add(btnFinalizar);
            pnlCarrinho.Controls.Add(lblTotal);
            pnlCarrinho.Controls.Add(cboPagamento);
            pnlCarrinho.Controls.Add(lblPagamento);
            pnlCarrinho.Controls.Add(txtCliente);
            pnlCarrinho.Controls.Add(lblCliente);
            pnlCarrinho.Controls.Add(btnRemover);
            pnlCarrinho.Controls.Add(lvCarrinho);
            pnlCarrinho.Controls.Add(lblCarrinho);
            pnlCarrinho.Dock = DockStyle.Right;
            pnlCarrinho.Location = new Point(840, 70);
            pnlCarrinho.Name = "pnlCarrinho";
            pnlCarrinho.Size = new Size(360, 690);
            pnlCarrinho.TabIndex = 2;
            //
            // btnLimpar
            //
            btnLimpar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpar.Location = new Point(15, 640);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(330, 34);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "LIMPAR CARRINHO";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            //
            // btnFinalizar
            //
            btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFinalizar.Location = new Point(15, 588);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(330, 45);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "✔ FINALIZAR PEDIDO";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            //
            // lblTotal
            //
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(118, 255, 3);
            lblTotal.Location = new Point(15, 545);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(330, 35);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL: R$ 0,00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            //
            // cboPagamento
            //
            cboPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPagamento.Font = new Font("Segoe UI", 10F);
            cboPagamento.Location = new Point(15, 510);
            cboPagamento.Name = "cboPagamento";
            cboPagamento.Size = new Size(330, 25);
            cboPagamento.TabIndex = 6;
            //
            // lblPagamento
            //
            lblPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblPagamento.ForeColor = Color.FromArgb(170, 165, 195);
            lblPagamento.Location = new Point(15, 490);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(126, 14);
            lblPagamento.TabIndex = 5;
            lblPagamento.Text = "FORMA DE PAGAMENTO";
            //
            // txtCliente
            //
            txtCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Font = new Font("Segoe UI", 10F);
            txtCliente.Location = new Point(15, 455);
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Nome do cliente";
            txtCliente.Size = new Size(330, 25);
            txtCliente.TabIndex = 4;
            //
            // lblCliente
            //
            lblCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblCliente.ForeColor = Color.FromArgb(170, 165, 195);
            lblCliente.Location = new Point(15, 435);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(56, 14);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "CLIENTE";
            //
            // btnRemover
            //
            btnRemover.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRemover.Location = new Point(15, 390);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(330, 32);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "REMOVER ITEM SELECIONADO";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            //
            // lvCarrinho
            //
            lvCarrinho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvCarrinho.BackColor = Color.FromArgb(50, 43, 76);
            lvCarrinho.BorderStyle = BorderStyle.None;
            lvCarrinho.Columns.AddRange(new ColumnHeader[] { colJogo, colQtd, colSubtotal });
            lvCarrinho.Font = new Font("Segoe UI", 9.5F);
            lvCarrinho.ForeColor = Color.FromArgb(235, 235, 245);
            lvCarrinho.FullRowSelect = true;
            lvCarrinho.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvCarrinho.Location = new Point(15, 50);
            lvCarrinho.MultiSelect = false;
            lvCarrinho.Name = "lvCarrinho";
            lvCarrinho.Size = new Size(330, 330);
            lvCarrinho.TabIndex = 1;
            lvCarrinho.UseCompatibleStateImageBehavior = false;
            lvCarrinho.View = View.Details;
            //
            // colJogo
            //
            colJogo.Text = "Jogo";
            colJogo.Width = 180;
            //
            // colQtd
            //
            colQtd.Text = "Qtd";
            colQtd.TextAlign = HorizontalAlignment.Center;
            colQtd.Width = 45;
            //
            // colSubtotal
            //
            colSubtotal.Text = "Subtotal";
            colSubtotal.TextAlign = HorizontalAlignment.Right;
            colSubtotal.Width = 100;
            //
            // lblCarrinho
            //
            lblCarrinho.AutoSize = true;
            lblCarrinho.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblCarrinho.ForeColor = Color.FromArgb(255, 64, 129);
            lblCarrinho.Location = new Point(15, 15);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(130, 22);
            lblCarrinho.TabIndex = 0;
            lblCarrinho.Text = "🛒 CARRINHO";
            //
            // flpCards
            //
            flpCards.AutoScroll = true;
            flpCards.BackColor = Color.FromArgb(24, 20, 37);
            flpCards.Dock = DockStyle.Fill;
            flpCards.Location = new Point(0, 70);
            flpCards.Name = "flpCards";
            flpCards.Padding = new Padding(10);
            flpCards.Size = new Size(840, 690);
            flpCards.TabIndex = 1;
            //
            // FrmCatalogo
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 37);
            ClientSize = new Size(1200, 760);
            Controls.Add(flpCards);
            Controls.Add(pnlCarrinho);
            Controls.Add(pnlTopo);
            MinimumSize = new Size(1000, 700);
            Name = "FrmCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retro Games Store - Cards de Jogos";
            Load += FrmCatalogo_Load;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlCarrinho.ResumeLayout(false);
            pnlCarrinho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private TextBox txtBusca;
        private ComboBox cboPlataforma;
        private Button btnVoltar;
        private Panel pnlCarrinho;
        private Label lblCarrinho;
        private ListView lvCarrinho;
        private ColumnHeader colJogo;
        private ColumnHeader colQtd;
        private ColumnHeader colSubtotal;
        private Button btnRemover;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblPagamento;
        private ComboBox cboPagamento;
        private Label lblTotal;
        private Button btnFinalizar;
        private Button btnLimpar;
        private FlowLayoutPanel flpCards;
    }
}

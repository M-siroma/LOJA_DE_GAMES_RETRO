namespace LojaGamesRetro.Forms
{
    partial class FrmRelatorio
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
            lblTitulo = new Label();
            pnlFiltros = new Panel();
            btnLimparFiltro = new Button();
            btnFiltrar = new Button();
            cboPlataforma = new ComboBox();
            lblPlataforma = new Label();
            dtpAte = new DateTimePicker();
            lblAte = new Label();
            dtpDe = new DateTimePicker();
            lblDe = new Label();
            tlpResumo = new TableLayoutPanel();
            lblTotalPedidos = new Label();
            lblItensVendidos = new Label();
            lblFaturamento = new Label();
            lblTicketMedio = new Label();
            lblMaisVendido = new Label();
            splPedidos = new SplitContainer();
            dgvPedidos = new DataGridView();
            dgvItens = new DataGridView();
            lblItensPedido = new Label();
            pnlTopo.SuspendLayout();
            pnlFiltros.SuspendLayout();
            tlpResumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splPedidos).BeginInit();
            splPedidos.Panel1.SuspendLayout();
            splPedidos.Panel2.SuspendLayout();
            splPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            //
            // pnlTopo
            //
            pnlTopo.BackColor = Color.FromArgb(38, 32, 58);
            pnlTopo.Controls.Add(btnVoltar);
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
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "← VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 229, 255);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(351, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📊 RELATÓRIO DE VENDAS";
            //
            // pnlFiltros
            //
            pnlFiltros.Controls.Add(btnLimparFiltro);
            pnlFiltros.Controls.Add(btnFiltrar);
            pnlFiltros.Controls.Add(cboPlataforma);
            pnlFiltros.Controls.Add(lblPlataforma);
            pnlFiltros.Controls.Add(dtpAte);
            pnlFiltros.Controls.Add(lblAte);
            pnlFiltros.Controls.Add(dtpDe);
            pnlFiltros.Controls.Add(lblDe);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 70);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1200, 60);
            pnlFiltros.TabIndex = 1;
            // 
            // btnLimparFiltro
            //
            btnLimparFiltro.Location = new Point(765, 14);
            btnLimparFiltro.Name = "btnLimparFiltro";
            btnLimparFiltro.Size = new Size(110, 32);
            btnLimparFiltro.TabIndex = 7;
            btnLimparFiltro.Text = "LIMPAR";
            btnLimparFiltro.UseVisualStyleBackColor = false;
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            //
            // btnFiltrar
            //
            btnFiltrar.Location = new Point(645, 14);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(110, 32);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            //
            // cboPlataforma
            //
            cboPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlataforma.Font = new Font("Segoe UI", 10F);
            cboPlataforma.Location = new Point(455, 17);
            cboPlataforma.Name = "cboPlataforma";
            cboPlataforma.Size = new Size(175, 25);
            cboPlataforma.TabIndex = 5;
            //
            // lblPlataforma
            //
            lblPlataforma.AutoSize = true;
            lblPlataforma.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblPlataforma.ForeColor = Color.FromArgb(170, 165, 195);
            lblPlataforma.Location = new Point(365, 22);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(84, 14);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "PLATAFORMA";
            //
            // dtpAte
            //
            dtpAte.Font = new Font("Segoe UI", 10F);
            dtpAte.Format = DateTimePickerFormat.Short;
            dtpAte.Location = new Point(230, 17);
            dtpAte.Name = "dtpAte";
            dtpAte.Size = new Size(120, 25);
            dtpAte.TabIndex = 3;
            //
            // lblAte
            //
            lblAte.AutoSize = true;
            lblAte.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblAte.ForeColor = Color.FromArgb(170, 165, 195);
            lblAte.Location = new Point(195, 22);
            lblAte.Name = "lblAte";
            lblAte.Size = new Size(28, 14);
            lblAte.TabIndex = 2;
            lblAte.Text = "ATÉ";
            //
            // dtpDe
            //
            dtpDe.Font = new Font("Segoe UI", 10F);
            dtpDe.Format = DateTimePickerFormat.Short;
            dtpDe.Location = new Point(60, 17);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(120, 25);
            dtpDe.TabIndex = 1;
            //
            // lblDe
            //
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lblDe.ForeColor = Color.FromArgb(170, 165, 195);
            lblDe.Location = new Point(20, 22);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(21, 14);
            lblDe.TabIndex = 0;
            lblDe.Text = "DE";
            //
            // tlpResumo
            //
            tlpResumo.ColumnCount = 5;
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpResumo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpResumo.Controls.Add(lblTotalPedidos, 0, 0);
            tlpResumo.Controls.Add(lblItensVendidos, 1, 0);
            tlpResumo.Controls.Add(lblFaturamento, 2, 0);
            tlpResumo.Controls.Add(lblTicketMedio, 3, 0);
            tlpResumo.Controls.Add(lblMaisVendido, 4, 0);
            tlpResumo.Dock = DockStyle.Top;
            tlpResumo.Location = new Point(0, 130);
            tlpResumo.Name = "tlpResumo";
            tlpResumo.Padding = new Padding(10, 0, 10, 10);
            tlpResumo.RowCount = 1;
            tlpResumo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpResumo.Size = new Size(1200, 95);
            tlpResumo.TabIndex = 2;
            //
            // lblTotalPedidos
            //
            lblTotalPedidos.BackColor = Color.FromArgb(50, 43, 76);
            lblTotalPedidos.Dock = DockStyle.Fill;
            lblTotalPedidos.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTotalPedidos.ForeColor = Color.FromArgb(0, 229, 255);
            lblTotalPedidos.Margin = new Padding(6);
            lblTotalPedidos.Name = "lblTotalPedidos";
            lblTotalPedidos.TabIndex = 0;
            lblTotalPedidos.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblItensVendidos
            //
            lblItensVendidos.BackColor = Color.FromArgb(50, 43, 76);
            lblItensVendidos.Dock = DockStyle.Fill;
            lblItensVendidos.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblItensVendidos.ForeColor = Color.FromArgb(0, 229, 255);
            lblItensVendidos.Margin = new Padding(6);
            lblItensVendidos.Name = "lblItensVendidos";
            lblItensVendidos.TabIndex = 1;
            lblItensVendidos.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblFaturamento
            //
            lblFaturamento.BackColor = Color.FromArgb(50, 43, 76);
            lblFaturamento.Dock = DockStyle.Fill;
            lblFaturamento.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblFaturamento.ForeColor = Color.FromArgb(118, 255, 3);
            lblFaturamento.Margin = new Padding(6);
            lblFaturamento.Name = "lblFaturamento";
            lblFaturamento.TabIndex = 2;
            lblFaturamento.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTicketMedio
            //
            lblTicketMedio.BackColor = Color.FromArgb(50, 43, 76);
            lblTicketMedio.Dock = DockStyle.Fill;
            lblTicketMedio.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTicketMedio.ForeColor = Color.FromArgb(0, 229, 255);
            lblTicketMedio.Margin = new Padding(6);
            lblTicketMedio.Name = "lblTicketMedio";
            lblTicketMedio.TabIndex = 3;
            lblTicketMedio.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblMaisVendido
            //
            lblMaisVendido.AutoEllipsis = true;
            lblMaisVendido.BackColor = Color.FromArgb(50, 43, 76);
            lblMaisVendido.Dock = DockStyle.Fill;
            lblMaisVendido.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblMaisVendido.ForeColor = Color.FromArgb(255, 64, 129);
            lblMaisVendido.Margin = new Padding(6);
            lblMaisVendido.Name = "lblMaisVendido";
            lblMaisVendido.TabIndex = 4;
            lblMaisVendido.TextAlign = ContentAlignment.MiddleCenter;
            //
            // splPedidos
            //
            splPedidos.Dock = DockStyle.Fill;
            splPedidos.Location = new Point(0, 225);
            splPedidos.Name = "splPedidos";
            splPedidos.Orientation = Orientation.Horizontal;
            //
            // splPedidos.Panel1
            //
            splPedidos.Panel1.Controls.Add(dgvPedidos);
            splPedidos.Panel1.Padding = new Padding(16, 0, 16, 6);
            //
            // splPedidos.Panel2
            //
            splPedidos.Panel2.Controls.Add(dgvItens);
            splPedidos.Panel2.Controls.Add(lblItensPedido);
            splPedidos.Panel2.Padding = new Padding(16, 0, 16, 16);
            splPedidos.Size = new Size(1200, 535);
            splPedidos.SplitterDistance = 310;
            splPedidos.TabIndex = 3;
            //
            // dgvPedidos
            //
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.TabIndex = 0;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            //
            // dgvItens
            //
            dgvItens.Dock = DockStyle.Fill;
            dgvItens.Name = "dgvItens";
            dgvItens.TabIndex = 1;
            //
            // lblItensPedido
            //
            lblItensPedido.Dock = DockStyle.Top;
            lblItensPedido.Font = new Font("Consolas", 11F, FontStyle.Bold);
            lblItensPedido.ForeColor = Color.FromArgb(255, 64, 129);
            lblItensPedido.Name = "lblItensPedido";
            lblItensPedido.Size = new Size(1168, 28);
            lblItensPedido.TabIndex = 0;
            lblItensPedido.Text = "ITENS DO PEDIDO";
            lblItensPedido.TextAlign = ContentAlignment.MiddleLeft;
            //
            // FrmRelatorio
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 37);
            ClientSize = new Size(1200, 760);
            Controls.Add(splPedidos);
            Controls.Add(tlpResumo);
            Controls.Add(pnlFiltros);
            Controls.Add(pnlTopo);
            MinimumSize = new Size(1000, 650);
            Name = "FrmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retro Games Store - Relatório de Vendas";
            Load += FrmRelatorio_Load;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            tlpResumo.ResumeLayout(false);
            splPedidos.Panel1.ResumeLayout(false);
            splPedidos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splPedidos).EndInit();
            splPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private Button btnVoltar;
        private Panel pnlFiltros;
        private Label lblDe;
        private DateTimePicker dtpDe;
        private Label lblAte;
        private DateTimePicker dtpAte;
        private Label lblPlataforma;
        private ComboBox cboPlataforma;
        private Button btnFiltrar;
        private Button btnLimparFiltro;
        private TableLayoutPanel tlpResumo;
        private Label lblTotalPedidos;
        private Label lblItensVendidos;
        private Label lblFaturamento;
        private Label lblTicketMedio;
        private Label lblMaisVendido;
        private SplitContainer splPedidos;
        private DataGridView dgvPedidos;
        private DataGridView dgvItens;
        private Label lblItensPedido;
    }
}

namespace LojaGamesRetro.Forms
{
    partial class FrmMenu
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnLoja = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            lblResumo = new Label();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Consolas", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 229, 255);
            lblTitulo.Location = new Point(0, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(560, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🕹️ RETRO GAMES STORE";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Consolas", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(170, 165, 195);
            lblSubtitulo.Location = new Point(0, 78);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(560, 22);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "MENU PRINCIPAL";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnLoja
            //
            btnLoja.Location = new Point(130, 130);
            btnLoja.Name = "btnLoja";
            btnLoja.Size = new Size(300, 55);
            btnLoja.TabIndex = 2;
            btnLoja.Text = "🎮  CARDS DE JOGOS / PEDIDOS";
            btnLoja.UseVisualStyleBackColor = false;
            btnLoja.Click += btnLoja_Click;
            //
            // btnRelatorio
            //
            btnRelatorio.Location = new Point(130, 200);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(300, 55);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "📊  RELATÓRIO DE VENDAS";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            //
            // btnSair
            //
            btnSair.Location = new Point(130, 270);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(300, 55);
            btnSair.TabIndex = 4;
            btnSair.Text = "⏻  SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            //
            // lblResumo
            //
            lblResumo.Font = new Font("Consolas", 9F);
            lblResumo.ForeColor = Color.FromArgb(118, 255, 3);
            lblResumo.Location = new Point(0, 350);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(560, 22);
            lblResumo.TabIndex = 5;
            lblResumo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FrmMenu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 37);
            ClientSize = new Size(560, 400);
            Controls.Add(lblResumo);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnLoja);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retro Games Store - Menu";
            Load += FrmMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnLoja;
        private Button btnRelatorio;
        private Button btnSair;
        private Label lblResumo;
    }
}

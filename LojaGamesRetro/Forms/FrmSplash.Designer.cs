namespace LojaGamesRetro.Forms
{
    partial class FrmSplash
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
            components = new System.ComponentModel.Container();
            lblLogo = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblStatus = new Label();
            pbCarregamento = new ProgressBar();
            lblVersao = new Label();
            tmrCarregamento = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // lblLogo
            //
            lblLogo.Font = new Font("Segoe UI Emoji", 40F);
            lblLogo.ForeColor = Color.FromArgb(255, 64, 129);
            lblLogo.Location = new Point(10, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(580, 80);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🕹️";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTitulo
            //
            lblTitulo.Font = new Font("Consolas", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 229, 255);
            lblTitulo.Location = new Point(10, 115);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(580, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "RETRO GAMES STORE";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Font = new Font("Consolas", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(170, 165, 195);
            lblSubtitulo.Location = new Point(10, 165);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(580, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Clássicos de 8, 16, 32 e 64 bits";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatus
            //
            lblStatus.Font = new Font("Consolas", 10F);
            lblStatus.ForeColor = Color.FromArgb(118, 255, 3);
            lblStatus.Location = new Point(50, 235);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(500, 22);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Inicializando...";
            //
            // pbCarregamento
            //
            pbCarregamento.Location = new Point(50, 260);
            pbCarregamento.Name = "pbCarregamento";
            pbCarregamento.Size = new Size(500, 18);
            pbCarregamento.Style = ProgressBarStyle.Continuous;
            pbCarregamento.TabIndex = 4;
            //
            // lblVersao
            //
            lblVersao.Font = new Font("Consolas", 8F);
            lblVersao.ForeColor = Color.FromArgb(170, 165, 195);
            lblVersao.Location = new Point(10, 300);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(575, 20);
            lblVersao.TabIndex = 5;
            lblVersao.Text = "v1.0 - C# Development";
            lblVersao.TextAlign = ContentAlignment.MiddleRight;
            //
            // tmrCarregamento
            //
            tmrCarregamento.Interval = 40;
            tmrCarregamento.Tick += tmrCarregamento_Tick;
            //
            // FrmSplash
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 37);
            ClientSize = new Size(600, 330);
            Controls.Add(lblVersao);
            Controls.Add(pbCarregamento);
            Controls.Add(lblStatus);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            ShowInTaskbar = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retro Games Store";
            Load += FrmSplash_Load;
            Paint += FrmSplash_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Label lblLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblStatus;
        private ProgressBar pbCarregamento;
        private Label lblVersao;
        private System.Windows.Forms.Timer tmrCarregamento;
    }
}

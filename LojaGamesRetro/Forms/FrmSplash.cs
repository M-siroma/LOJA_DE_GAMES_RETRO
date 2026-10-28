namespace LojaGamesRetro.Forms
{
    public partial class FrmSplash : Form
    {
        private static readonly (int Progresso, string Mensagem)[] Etapas =
        {
            (0,  "Inicializando..."),
            (15, "Soprando os cartuchos..."),
            (35, "Carregando catálogo de jogos..."),
            (55, "Conectando os controles..."),
            (75, "Carregando histórico de vendas..."),
            (95, "Press START!"),
        };

        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            tmrCarregamento.Start();
        }

        private void tmrCarregamento_Tick(object sender, EventArgs e)
        {
            if (pbCarregamento.Value >= pbCarregamento.Maximum)
            {
                tmrCarregamento.Stop();
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            pbCarregamento.Value = Math.Min(pbCarregamento.Maximum, pbCarregamento.Value + 1);
            lblStatus.Text = Etapas.Last(etapa => pbCarregamento.Value >= etapa.Progresso).Mensagem;
        }

        private void FrmSplash_Paint(object sender, PaintEventArgs e)
        {
            using var borda = new Pen(Color.FromArgb(255, 64, 129), 3);
            e.Graphics.DrawRectangle(borda, 1, 1, ClientSize.Width - 3, ClientSize.Height - 3);
        }
    }
}

using LojaGamesRetro.Services;

namespace LojaGamesRetro.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            Tema.EstilizarBotao(btnLoja, Tema.Secundaria);
            Tema.EstilizarBotao(btnRelatorio, Tema.Sucesso);
            Tema.EstilizarBotao(btnSair, Tema.Destaque);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            AtualizarResumo();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            AbrirTela(new FrmCatalogo());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            AbrirTela(new FrmRelatorio());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void AbrirTela(Form tela)
        {
            Hide();
            using (tela)
            {
                tela.ShowDialog();
            }
            AtualizarResumo();
            Show();
        }

        private void AtualizarResumo()
        {
            var hoje = LojaService.Pedidos.Where(p => p.Data.Date == DateTime.Today).ToList();
            lblResumo.Text = $"Vendas hoje: {hoje.Count} pedido(s) | {hoje.Sum(p => p.Total):C}";
        }
    }
}

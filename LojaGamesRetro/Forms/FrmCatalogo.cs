using LojaGamesRetro.Models;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Forms
{
    public partial class FrmCatalogo : Form
    {
        // id do jogo -> quantidade
        private Dictionary<int, int> carrinho = new Dictionary<int, int>();

        public FrmCatalogo()
        {
            InitializeComponent();
            Tema.EstilizarBotao(btnVoltar, Tema.TextoSuave);
            Tema.EstilizarBotao(btnRemover, Tema.TextoSuave);
            Tema.EstilizarBotao(btnFinalizar, Tema.Sucesso);
            Tema.EstilizarBotao(btnLimpar, Tema.Destaque);
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            cboPlataforma.Items.Add("Todas as plataformas");
            foreach (var plataforma in LojaService.Plataformas)
                cboPlataforma.Items.Add(plataforma);
            cboPlataforma.SelectedIndex = 0;

            cboPagamento.Items.AddRange(LojaService.FormasPagamento);
            cboPagamento.SelectedIndex = 0;

            AtualizarCarrinho();
        }

        private void Filtro_Changed(object? sender, EventArgs e)
        {
            CarregarCards();
        }

        private void CarregarCards()
        {
            string busca = txtBusca.Text.Trim();
            string plataforma = cboPlataforma.SelectedIndex > 0 ? cboPlataforma.Text : "";

            flpCards.SuspendLayout();
            flpCards.Controls.Clear();

            foreach (var jogo in LojaService.Jogos)
            {
                if (plataforma != "" && jogo.Plataforma != plataforma)
                    continue;
                if (busca != "" && !jogo.Nome.Contains(busca, StringComparison.OrdinalIgnoreCase))
                    continue;

                var card = new CardJogo(jogo, EstoqueRestante(jogo.Id));
                card.Adicionar += AdicionarAoCarrinho;
                flpCards.Controls.Add(card);
            }

            if (flpCards.Controls.Count == 0)
            {
                flpCards.Controls.Add(new Label
                {
                    Text = "Nenhum jogo encontrado :(",
                    AutoSize = true,
                    Font = Tema.Subtitulo,
                    ForeColor = Tema.TextoSuave,
                });
            }

            flpCards.ResumeLayout();
        }

        // estoque menos o que já ta no carrinho
        private int EstoqueRestante(int jogoId)
        {
            int noCarrinho = carrinho.ContainsKey(jogoId) ? carrinho[jogoId] : 0;
            return LojaService.EstoqueDisponivel(jogoId) - noCarrinho;
        }

        private void AdicionarAoCarrinho(Jogo jogo, int quantidade)
        {
            if (quantidade <= 0)
                return;

            if (quantidade > EstoqueRestante(jogo.Id))
            {
                MessageBox.Show("Não tem estoque suficiente de " + jogo.Nome);
                return;
            }

            if (carrinho.ContainsKey(jogo.Id))
                carrinho[jogo.Id] += quantidade;
            else
                carrinho[jogo.Id] = quantidade;

            AtualizarCarrinho();
        }

        private void AtualizarCarrinho()
        {
            lvCarrinho.Items.Clear();
            decimal total = 0;

            foreach (var item in carrinho)
            {
                var jogo = LojaService.Jogos.First(j => j.Id == item.Key);
                decimal subtotal = jogo.Preco * item.Value;
                total += subtotal;

                var linha = new ListViewItem(jogo.Nome);
                linha.SubItems.Add(item.Value.ToString());
                linha.SubItems.Add(subtotal.ToString("C"));
                linha.Tag = jogo.Id;
                lvCarrinho.Items.Add(linha);
            }

            lblTotal.Text = "TOTAL: " + total.ToString("C");
            btnFinalizar.Enabled = carrinho.Count > 0;

            // recarrega os cards pra atualizar o estoque
            CarregarCards();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lvCarrinho.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item do carrinho primeiro");
                return;
            }

            carrinho.Remove((int)lvCarrinho.SelectedItems[0].Tag!);
            AtualizarCarrinho();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
                return;

            if (MessageBox.Show("Quer limpar o carrinho?", "Carrinho", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                carrinho.Clear();
                AtualizarCarrinho();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do cliente!");
                txtCliente.Focus();
                return;
            }

            try
            {
                var pedido = LojaService.RegistrarPedido(txtCliente.Text, cboPagamento.Text, carrinho);

                MessageBox.Show("Pedido #" + pedido.Numero + " finalizado!\n\n" +
                    "Cliente: " + pedido.Cliente + "\n" +
                    "Itens: " + pedido.QuantidadeItens + "\n" +
                    "Pagamento: " + pedido.FormaPagamento + "\n" +
                    "Total: " + pedido.Total.ToString("C"), "Pedido finalizado");

                carrinho.Clear();
                txtCliente.Clear();
                cboPagamento.SelectedIndex = 0;
                AtualizarCarrinho();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count > 0)
            {
                var resp = MessageBox.Show("Tem itens no carrinho, quer sair mesmo assim?", "Voltar", MessageBoxButtons.YesNo);
                if (resp == DialogResult.No)
                    return;
            }

            Close();
        }
    }
}

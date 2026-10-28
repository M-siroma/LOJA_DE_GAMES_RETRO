using LojaGamesRetro.Models;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Forms
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
            Tema.EstilizarBotao(btnVoltar, Tema.TextoSuave);
            Tema.EstilizarBotao(btnFiltrar, Tema.Secundaria);
            Tema.EstilizarBotao(btnLimparFiltro, Tema.TextoSuave);
            Tema.EstilizarGrid(dgvPedidos);
            Tema.EstilizarGrid(dgvItens);
            CriarColunas();
        }

        private void CriarColunas()
        {
            dgvPedidos.Columns.Add("Pedido", "Nº");
            dgvPedidos.Columns.Add("Data", "Data");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Pagamento", "Pagamento");
            dgvPedidos.Columns.Add("Itens", "Itens");
            dgvPedidos.Columns.Add("Total", "Total");
            dgvPedidos.Columns["Pedido"]!.FillWeight = 40;
            dgvPedidos.Columns["Itens"]!.FillWeight = 40;
            dgvPedidos.Columns["Cliente"]!.FillWeight = 150;
            dgvPedidos.Columns["Total"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItens.Columns.Add("Jogo", "Jogo");
            dgvItens.Columns.Add("Plataforma", "Plataforma");
            dgvItens.Columns.Add("Qtd", "Qtd");
            dgvItens.Columns.Add("Preco", "Preço Unit.");
            dgvItens.Columns.Add("Subtotal", "Subtotal");
            dgvItens.Columns["Jogo"]!.FillWeight = 200;
            dgvItens.Columns["Qtd"]!.FillWeight = 40;
            dgvItens.Columns["Preco"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItens.Columns["Subtotal"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            cboPlataforma.Items.Add("Todas");
            foreach (var plataforma in LojaService.Plataformas)
                cboPlataforma.Items.Add(plataforma);

            LimparFiltros();
        }

        private void LimparFiltros()
        {
            // começa na data da primeira venda
            if (LojaService.Pedidos.Count > 0)
                dtpDe.Value = LojaService.Pedidos.Min(p => p.Data).Date;
            else
                dtpDe.Value = DateTime.Today;

            dtpAte.Value = DateTime.Today;
            cboPlataforma.SelectedIndex = 0;
            Filtrar();
        }

        private void Filtrar()
        {
            if (dtpDe.Value.Date > dtpAte.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a final");
                return;
            }

            string plataforma = cboPlataforma.SelectedIndex > 0 ? cboPlataforma.Text : "";

            var pedidos = RelatorioService.FiltrarPedidos(dtpDe.Value, dtpAte.Value, plataforma);
            var itens = RelatorioService.FiltrarItens(pedidos, plataforma);

            lblTotalPedidos.Text = "PEDIDOS\n" + pedidos.Count;
            lblItensVendidos.Text = "ITENS VENDIDOS\n" + itens.Sum(i => i.Quantidade);
            lblFaturamento.Text = "FATURAMENTO\n" + RelatorioService.Faturamento(itens).ToString("C");
            lblTicketMedio.Text = "TICKET MÉDIO\n" + RelatorioService.TicketMedio(pedidos, itens).ToString("C");
            lblMaisVendido.Text = "MAIS VENDIDO\n" + RelatorioService.MaisVendido(itens);

            dgvPedidos.Rows.Clear();
            foreach (var pedido in pedidos)
            {
                int i = dgvPedidos.Rows.Add(
                    pedido.Numero.ToString("D4"),
                    pedido.Data.ToString("dd/MM/yyyy HH:mm"),
                    pedido.Cliente,
                    pedido.FormaPagamento,
                    pedido.QuantidadeItens,
                    pedido.Total.ToString("C"));
                dgvPedidos.Rows[i].Tag = pedido;
            }

            MostrarItens();
        }

        private void MostrarItens()
        {
            dgvItens.Rows.Clear();
            lblItensPedido.Text = "ITENS DO PEDIDO";

            if (dgvPedidos.SelectedRows.Count == 0)
                return;

            var pedido = dgvPedidos.SelectedRows[0].Tag as Pedido;
            if (pedido == null)
                return;

            lblItensPedido.Text = "ITENS DO PEDIDO #" + pedido.Numero.ToString("D4") + " - " + pedido.Cliente;
            foreach (var item in pedido.Itens)
            {
                dgvItens.Rows.Add(item.NomeJogo, item.Plataforma, item.Quantidade,
                    item.PrecoUnitario.ToString("C"), item.Subtotal.ToString("C"));
            }
        }

        private void dgvPedidos_SelectionChanged(object? sender, EventArgs e)
        {
            MostrarItens();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

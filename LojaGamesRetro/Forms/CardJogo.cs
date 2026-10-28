using LojaGamesRetro.Models;
using LojaGamesRetro.Services;

namespace LojaGamesRetro.Forms
{
    // card de cada jogo na tela de pedidos
    public class CardJogo : Panel
    {
        public event Action<Jogo, int>? Adicionar;

        private readonly Jogo jogo;

        public CardJogo(Jogo jogo, int estoque)
        {
            this.jogo = jogo;

            Size = S(190, 330);
            BackColor = Tema.Card;
            Margin = new Padding(10);

            var capa = new Panel { Location = P(10, 10), Size = S(170, 120), BackColor = jogo.Cor };
            capa.Paint += Capa_Paint;

            var lblNome = new Label
            {
                Text = jogo.Nome,
                Location = P(10, 138),
                Size = S(170, 40),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Tema.Texto,
                AutoEllipsis = true,
            };

            var lblInfo = new Label
            {
                Text = jogo.Plataforma + " - " + jogo.Ano + "\n" + jogo.Genero,
                Location = P(10, 180),
                Size = S(170, 36),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Tema.TextoSuave,
            };

            var lblPreco = new Label
            {
                Text = jogo.Preco.ToString("C"),
                Location = P(10, 216),
                Size = S(170, 26),
                Font = new Font("Consolas", 13F, FontStyle.Bold),
                ForeColor = Tema.Sucesso,
            };

            var lblEstoque = new Label
            {
                Text = estoque > 0 ? "Estoque: " + estoque : "ESGOTADO",
                Location = P(10, 244),
                Size = S(170, 18),
                Font = new Font("Consolas", 8.5F, FontStyle.Bold),
                ForeColor = estoque > 0 ? Tema.TextoSuave : Tema.Destaque,
            };

            var nudQtd = new NumericUpDown
            {
                Location = P(10, 285),
                Size = S(55, 25),
                Minimum = estoque > 0 ? 1 : 0,
                Maximum = Math.Max(estoque, 0),
                Enabled = estoque > 0,
                Font = new Font("Segoe UI", 10F),
            };

            var btnAdicionar = new Button
            {
                Text = "+ ADICIONAR",
                Location = P(72, 283),
                Size = S(108, 30),
                Enabled = estoque > 0,
            };
            Tema.EstilizarBotao(btnAdicionar, estoque > 0 ? Tema.Secundaria : Tema.TextoSuave);
            btnAdicionar.Font = new Font("Consolas", 8.5F, FontStyle.Bold);
            btnAdicionar.Click += (s, e) => Adicionar?.Invoke(jogo, (int)nudQtd.Value);

            Controls.Add(capa);
            Controls.Add(lblNome);
            Controls.Add(lblInfo);
            Controls.Add(lblPreco);
            Controls.Add(lblEstoque);
            Controls.Add(nudQtd);
            Controls.Add(btnAdicionar);
        }

        private void Capa_Paint(object? sender, PaintEventArgs e)
        {
            var area = ((Panel)sender!).ClientRectangle;

            // pega as iniciais do nome tipo "Super Mario World" -> SMW
            string iniciais = "";
            foreach (var palavra in jogo.Nome.Split(' '))
            {
                if (iniciais.Length < 3 && palavra.Length > 0 && char.IsLetterOrDigit(palavra[0]))
                    iniciais += char.ToUpper(palavra[0]);
            }

            var centro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(iniciais, new Font("Consolas", 30F, FontStyle.Bold), Brushes.White, area, centro);

            var faixa = new Rectangle(0, area.Height - 20, area.Width, 20);
            e.Graphics.FillRectangle(Brushes.Black, faixa);
            e.Graphics.DrawString(jogo.Plataforma.ToUpper(), new Font("Consolas", 8F, FontStyle.Bold), Brushes.White, faixa, centro);
        }

        // ajusta o tamanho pra telas com zoom (125%, 150%...)
        private Point P(int x, int y) => new Point(LogicalToDeviceUnits(x), LogicalToDeviceUnits(y));
        private Size S(int w, int h) => new Size(LogicalToDeviceUnits(w), LogicalToDeviceUnits(h));
    }
}

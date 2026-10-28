using System.Text.Json;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Services
{
    // lista de jogos e as vendas (salvas num json pra não perder quando fechar)
    public static class LojaService
    {
        private static readonly string PastaDados = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LojaGamesRetro");

        private static readonly string ArquivoVendas = Path.Combine(PastaDados, "vendas.json");

        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

        private static readonly List<Pedido> pedidos = new();

        public static IReadOnlyList<Jogo> Jogos { get; } = new List<Jogo>
        {
            new() { Id = 1,  Nome = "Super Mario World",          Plataforma = "Super Nintendo", Genero = "Plataforma", Ano = 1990, Preco = 249.90m, EstoqueInicial = 8,  Cor = Color.FromArgb(220, 60, 60) },
            new() { Id = 2,  Nome = "The Legend of Zelda: A Link to the Past", Plataforma = "Super Nintendo", Genero = "Aventura", Ano = 1991, Preco = 289.90m, EstoqueInicial = 5, Cor = Color.FromArgb(60, 150, 70) },
            new() { Id = 3,  Nome = "Donkey Kong Country",        Plataforma = "Super Nintendo", Genero = "Plataforma", Ano = 1994, Preco = 199.90m, EstoqueInicial = 6,  Cor = Color.FromArgb(150, 90, 40) },
            new() { Id = 4,  Nome = "Sonic the Hedgehog 2",       Plataforma = "Mega Drive",     Genero = "Plataforma", Ano = 1992, Preco = 159.90m, EstoqueInicial = 10, Cor = Color.FromArgb(40, 90, 200) },
            new() { Id = 5,  Nome = "Streets of Rage 2",          Plataforma = "Mega Drive",     Genero = "Beat 'em up", Ano = 1992, Preco = 219.90m, EstoqueInicial = 4, Cor = Color.FromArgb(200, 80, 140) },
            new() { Id = 6,  Nome = "Super Mario Bros. 3",        Plataforma = "NES",            Genero = "Plataforma", Ano = 1988, Preco = 179.90m, EstoqueInicial = 7,  Cor = Color.FromArgb(230, 140, 30) },
            new() { Id = 7,  Nome = "Mega Man 2",                 Plataforma = "NES",            Genero = "Ação",       Ano = 1988, Preco = 169.90m, EstoqueInicial = 5,  Cor = Color.FromArgb(50, 160, 220) },
            new() { Id = 8,  Nome = "Pac-Man",                    Plataforma = "Atari 2600",     Genero = "Arcade",     Ano = 1982, Preco = 89.90m,  EstoqueInicial = 12, Cor = Color.FromArgb(230, 200, 30) },
            new() { Id = 9,  Nome = "Pitfall!",                   Plataforma = "Atari 2600",     Genero = "Aventura",   Ano = 1982, Preco = 79.90m,  EstoqueInicial = 9,  Cor = Color.FromArgb(90, 130, 50) },
            new() { Id = 10, Nome = "Pokémon Red",                Plataforma = "Game Boy",       Genero = "RPG",        Ano = 1996, Preco = 229.90m, EstoqueInicial = 6,  Cor = Color.FromArgb(200, 40, 40) },
            new() { Id = 11, Nome = "Tetris",                     Plataforma = "Game Boy",       Genero = "Puzzle",     Ano = 1989, Preco = 99.90m,  EstoqueInicial = 15, Cor = Color.FromArgb(120, 90, 200) },
            new() { Id = 12, Nome = "Super Mario 64",             Plataforma = "Nintendo 64",    Genero = "Plataforma", Ano = 1996, Preco = 259.90m, EstoqueInicial = 6,  Cor = Color.FromArgb(200, 50, 90) },
            new() { Id = 13, Nome = "GoldenEye 007",              Plataforma = "Nintendo 64",    Genero = "Tiro",       Ano = 1997, Preco = 189.90m, EstoqueInicial = 5,  Cor = Color.FromArgb(70, 70, 80) },
            new() { Id = 14, Nome = "Crash Bandicoot",            Plataforma = "PlayStation",    Genero = "Plataforma", Ano = 1996, Preco = 149.90m, EstoqueInicial = 8,  Cor = Color.FromArgb(230, 110, 30) },
            new() { Id = 15, Nome = "Final Fantasy VII",          Plataforma = "PlayStation",    Genero = "RPG",        Ano = 1997, Preco = 199.90m, EstoqueInicial = 4,  Cor = Color.FromArgb(40, 60, 120) },
        };

        public static IReadOnlyList<Pedido> Pedidos => pedidos;

        public static IEnumerable<string> Plataformas =>
            Jogos.Select(j => j.Plataforma).Distinct().OrderBy(p => p);

        public static string[] FormasPagamento { get; } = { "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" };

        public static void Carregar()
        {
            pedidos.Clear();
            if (!File.Exists(ArquivoVendas))
                return;

            try
            {
                var lidos = JsonSerializer.Deserialize<List<Pedido>>(File.ReadAllText(ArquivoVendas), JsonOptions);
                if (lidos != null)
                    pedidos.AddRange(lidos);
            }
            catch
            {
                // se o arquivo der problema começa sem vendas
            }
        }

        public static int EstoqueDisponivel(int jogoId)
        {
            var jogo = Jogos.First(j => j.Id == jogoId);
            var vendidos = pedidos.SelectMany(p => p.Itens).Where(i => i.JogoId == jogoId).Sum(i => i.Quantidade);
            return Math.Max(0, jogo.EstoqueInicial - vendidos);
        }

        public static Pedido RegistrarPedido(string cliente, string formaPagamento, IDictionary<int, int> carrinho)
        {
            if (string.IsNullOrWhiteSpace(cliente))
                throw new Exception("Digite o nome do cliente!");
            if (carrinho.Count == 0)
                throw new Exception("O carrinho está vazio!");

            var pedido = new Pedido
            {
                Numero = pedidos.Count == 0 ? 1 : pedidos.Max(p => p.Numero) + 1,
                Data = DateTime.Now,
                Cliente = cliente.Trim(),
                FormaPagamento = formaPagamento,
            };

            foreach (var (jogoId, quantidade) in carrinho)
            {
                var jogo = Jogos.First(j => j.Id == jogoId);
                if (quantidade > EstoqueDisponivel(jogoId))
                    throw new Exception("Não tem estoque suficiente de " + jogo.Nome);

                pedido.Itens.Add(new ItemPedido
                {
                    JogoId = jogo.Id,
                    NomeJogo = jogo.Nome,
                    Plataforma = jogo.Plataforma,
                    Quantidade = quantidade,
                    PrecoUnitario = jogo.Preco,
                });
            }

            pedidos.Add(pedido);
            Salvar();
            return pedido;
        }

        private static void Salvar()
        {
            Directory.CreateDirectory(PastaDados);
            File.WriteAllText(ArquivoVendas, JsonSerializer.Serialize(pedidos, JsonOptions));
        }
    }
}

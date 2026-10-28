namespace LojaGamesRetro.Models
{
    public class Jogo
    {
        public int Id { get; init; }
        public string Nome { get; init; } = string.Empty;
        public string Plataforma { get; init; } = string.Empty;
        public string Genero { get; init; } = string.Empty;
        public int Ano { get; init; }
        public decimal Preco { get; init; }
        public int EstoqueInicial { get; init; }
        public Color Cor { get; init; } = Color.SlateBlue;
    }
}

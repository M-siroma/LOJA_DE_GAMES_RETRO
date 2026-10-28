using System.Text.Json.Serialization;

namespace LojaGamesRetro.Models
{
    public class ItemPedido
    {
        public int JogoId { get; set; }
        public string NomeJogo { get; set; } = string.Empty;
        public string Plataforma { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        [JsonIgnore]
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }

    public class Pedido
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string FormaPagamento { get; set; } = string.Empty;
        public List<ItemPedido> Itens { get; set; } = new();

        [JsonIgnore]
        public int QuantidadeItens => Itens.Sum(i => i.Quantidade);

        [JsonIgnore]
        public decimal Total => Itens.Sum(i => i.Subtotal);
    }
}

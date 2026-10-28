using LojaGamesRetro.Models;

namespace LojaGamesRetro.Services
{
    // contas usadas na tela de relatório
    public static class RelatorioService
    {
        // plataforma vazia = todas
        public static List<Pedido> FiltrarPedidos(DateTime de, DateTime ate, string plataforma)
        {
            return LojaService.Pedidos
                .Where(p => p.Data.Date >= de.Date && p.Data.Date <= ate.Date)
                .Where(p => plataforma == "" || p.Itens.Any(i => i.Plataforma == plataforma))
                .OrderByDescending(p => p.Data)
                .ToList();
        }

        public static List<ItemPedido> FiltrarItens(List<Pedido> pedidos, string plataforma)
        {
            return pedidos
                .SelectMany(p => p.Itens)
                .Where(i => plataforma == "" || i.Plataforma == plataforma)
                .ToList();
        }

        public static decimal Faturamento(List<ItemPedido> itens)
        {
            return itens.Sum(i => i.Subtotal);
        }

        public static decimal TicketMedio(List<Pedido> pedidos, List<ItemPedido> itens)
        {
            if (pedidos.Count == 0)
                return 0;
            return Faturamento(itens) / pedidos.Count;
        }

        public static string MaisVendido(List<ItemPedido> itens)
        {
            if (itens.Count == 0)
                return "-";

            var top = itens
                .GroupBy(i => i.NomeJogo)
                .OrderByDescending(g => g.Sum(i => i.Quantidade))
                .First();

            return top.Key + " (" + top.Sum(i => i.Quantidade) + ")";
        }
    }
}

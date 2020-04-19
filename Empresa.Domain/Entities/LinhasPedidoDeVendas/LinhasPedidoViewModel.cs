
namespace Empresa.Domain.Entities.LinhasPedidoDeVendas
{
    public class LinhasPedidoViewModel
    {
        public int ItemId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int Desconto { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
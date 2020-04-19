namespace Empresa.Domain.Entities.ItemEntity
{
    public class ItemViewModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double PrecoDeCompra { get; set; }
        public double PrecoDeVenda { get; set; }
    }
}

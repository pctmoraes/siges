using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Domain.Entities
{
    public class LinhasPedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LinhasId { get; set; }

        [ForeignKey("PedidoId")]
        public int PedidoId { get; set; }

        [ForeignKey("ItemId")]
        public int ItemId { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Codigo { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public int Desconto { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double ValorTotal { get; set; }

        public Item Item { get; set; }
    }
}
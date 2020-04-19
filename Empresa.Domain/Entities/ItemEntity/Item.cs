using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Domain.Entities
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Codigo { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double PrecoDeCompra { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double PrecoDeVenda { get; set; }

    }
}
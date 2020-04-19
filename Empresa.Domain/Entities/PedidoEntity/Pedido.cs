using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Domain.Entities
{
    public class Pedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PedidoId { get; set; }

        [ForeignKey("EmpresaId")]
        public int EmpresaId { get; set; }

        public DateTime DataDoPedido { get; set; }

        public DateTime DataDaEntrega { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Status { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double ValorSemDesconto { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public double ValorComDesconto { get; set; }

        public int Desconto { get; set; }

        public List<LinhasPedido> LinhasPedidos { get; set; }
    }
}

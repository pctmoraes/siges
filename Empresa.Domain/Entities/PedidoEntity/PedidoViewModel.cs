using Empresa.Domain.Entities.LinhasPedidoDeVendas;
using System;
using System.Collections.Generic;

namespace Empresa.Domain.Entities.PedidoEntity
{
    public class PedidoViewModel
    {
        public int EmpresaId { get; set; }
        public DateTime DataDoPedido { get; set; }
        public DateTime DataDaEntrega { get; set; }
        public double ValorSemDesconto { get; set; }
        public int PercentualDesconto { get; set; }
        public double ValorComDesconto { get; set; }
        public string Status { get; set; }
        public List<LinhasPedidoViewModel> LinhasPedidos { get; set; }
    }
}
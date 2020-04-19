using Empresa.Domain.Entities;
using Empresa.Domain.Entities.PedidoEntity;
using Empresa.Domain.Interfaces.Services.PedidoService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI_CadastroEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        #region INTERFACES
        private IConsultaPedidoService _consultaPedidoService;
        private IAdicionaPedidoService _adicionaPedidoService;
        private IAtualizaPedidoService _atualizaPedidoService;
        private IAtualizaStatusPedidoService _atualizaStatusPedidoService;

        public PedidoController(IConsultaPedidoService consultaPedidoService, IAdicionaPedidoService adicionaPedidoService, IAtualizaPedidoService atualizaPedidoService, IAtualizaStatusPedidoService atualizaStatusPedidoService)
        {
            _consultaPedidoService = consultaPedidoService;
            _adicionaPedidoService = adicionaPedidoService;
            _atualizaPedidoService = atualizaPedidoService;
            _atualizaStatusPedidoService = atualizaStatusPedidoService;
        }
        #endregion

        #region GET
        [HttpGet]
        public IEnumerable<Pedido> GetAll()
        {
            return _consultaPedidoService.Get();
        }
        #endregion

        #region GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_consultaPedidoService.GetId(id));
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Post([FromBody] PedidoViewModel pedido)
        {
            try
            {
              
                var novoPedido = new Pedido();
                {
                    novoPedido.EmpresaId = pedido.EmpresaId;
                    novoPedido.DataDoPedido = pedido.DataDoPedido;
                    novoPedido.DataDaEntrega = pedido.DataDaEntrega;
                    novoPedido.ValorSemDesconto = pedido.ValorSemDesconto;
                    novoPedido.ValorComDesconto = pedido.ValorComDesconto;
                    novoPedido.Desconto = pedido.PercentualDesconto;
                    novoPedido.Status = pedido.Status;

                    novoPedido.LinhasPedidos = new List<LinhasPedido>();

                    foreach (var linhaPedido in pedido.LinhasPedidos)
                    {
                        LinhasPedido novaLinhaPedido = new LinhasPedido();
                        
                        novaLinhaPedido.Desconto = linhaPedido.Desconto;
                        novaLinhaPedido.Quantidade = linhaPedido.Quantidade;
                        novaLinhaPedido.ValorTotal = Convert.ToDouble(linhaPedido.ValorTotal);
                        novaLinhaPedido.ItemId = linhaPedido.ItemId;
                        novaLinhaPedido.Descricao = linhaPedido.Descricao;
                        novaLinhaPedido.Preco = Convert.ToDouble(linhaPedido.Preco);
                        novaLinhaPedido.Codigo = linhaPedido.Codigo;

                        novoPedido.LinhasPedidos.Add(novaLinhaPedido);
                    }
                }

                _adicionaPedidoService.Create(novoPedido);
                return Created($"api/Pedido{pedido}", pedido);
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PedidoViewModel pedido)
        {
            try
            {
                var objPedido = new Pedido();
                {
                    objPedido.EmpresaId = pedido.EmpresaId;
                    objPedido.DataDoPedido = pedido.DataDoPedido;
                    objPedido.DataDaEntrega = pedido.DataDaEntrega;
                    objPedido.ValorSemDesconto = pedido.ValorSemDesconto;
                    objPedido.ValorComDesconto = pedido.ValorComDesconto;
                    objPedido.Desconto = pedido.PercentualDesconto;
                    objPedido.Status = pedido.Status;

                    objPedido.LinhasPedidos = new List<LinhasPedido>();

                    foreach (var linhaPedido in pedido.LinhasPedidos)
                    {
                        LinhasPedido novaLinhaPedido = new LinhasPedido();

                        novaLinhaPedido.Desconto = linhaPedido.Desconto;
                        novaLinhaPedido.Quantidade = linhaPedido.Quantidade;
                        novaLinhaPedido.ValorTotal = Convert.ToDouble(linhaPedido.ValorTotal);
                        novaLinhaPedido.ItemId = linhaPedido.ItemId;
                        novaLinhaPedido.Descricao = linhaPedido.Descricao;
                        novaLinhaPedido.Preco = Convert.ToDouble(linhaPedido.Preco);
                        novaLinhaPedido.Codigo = linhaPedido.Codigo;

                        objPedido.LinhasPedidos.Add(novaLinhaPedido);
                    }
                }

                _atualizaPedidoService.UpdatePedido(id, objPedido);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region PATCH
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, string status)
        {
            try
            {
                _atualizaStatusPedidoService.UpdateStatus(id, status);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion
    }
}
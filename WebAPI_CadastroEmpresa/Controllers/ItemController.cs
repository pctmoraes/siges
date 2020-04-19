using Empresa.Domain.Entities;
using Empresa.Domain.Entities.ItemEntity;
using Empresa.Domain.Interfaces.Services.ItemService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI_CadastroEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        #region INTERFACES
        private IConsultaItemService _consultaItemService;
        private IAdicionaItemService _adicionaItemService;
        private IAtualizaItemService _atualizaItemService;
        private IRemoveItemService _removeItemService;

        public ItemController(IConsultaItemService consultaItemService, IAdicionaItemService adicionaItemService, IAtualizaItemService atualizaItemService, IRemoveItemService removeItemService)
        {
            _consultaItemService = consultaItemService;
            _adicionaItemService = adicionaItemService;
            _atualizaItemService = atualizaItemService;
            _removeItemService = removeItemService;
        }
        #endregion

        #region GET
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            return _consultaItemService.Get();
        }
        #endregion

        #region GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_consultaItemService.GetId(id));
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Post([FromBody] ItemViewModel item)
        {
            try
            {
                _adicionaItemService.Create(item);
                return Created($"api/Item/{item.Codigo}", item);
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region PUT
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ItemViewModel item)
        {
            try
            {
                _atualizaItemService.Update(id, item);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _removeItemService.Delete(id);
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

using Microsoft.AspNetCore.Mvc;
using Empresa.Domain.Interfaces.Services;
using Empresa.Domain.Entities;
using System.Collections.Generic;

namespace WebAPI_CadastroEmpresa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmpresasController : ControllerBase
    {
        #region INTERFACES
        private IAdicionaEmpresaService _adicionaEmpresaService;
        private IAtualizaEmpresaService _atualizaEmpresaService;
        private IConsultaEmpresaService _consultaEmpresaService;
        private IRemoveEmpresaService _removeEmpresaService;

        public EmpresasController(IAdicionaEmpresaService adicionaEmpresaService, IAtualizaEmpresaService atualizaEmpresaService, IConsultaEmpresaService consultaEmpresaService, IRemoveEmpresaService removeEmpresaService)
        {
            _adicionaEmpresaService = adicionaEmpresaService;
            _atualizaEmpresaService = atualizaEmpresaService;
            _consultaEmpresaService = consultaEmpresaService;
            _removeEmpresaService = removeEmpresaService;
        }
        #endregion

        #region GET ALL
        [HttpGet]
        public IEnumerable<Empresa.Domain.Entities.Empresa> GetAll()
        {
            return _consultaEmpresaService.GetAll();
        }
        #endregion

        #region GET by CNPJ
        [HttpGet("{cnpj}")]
        public IActionResult GetByCnpj([FromRoute] string cnpj)
        {
            try
            {
                return Ok(_consultaEmpresaService.GetCnpj(cnpj));
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region POST
        [HttpPost]
        public IActionResult Create([FromBody] EmpresaViewModel empresa)
        {
            try
            {
                _adicionaEmpresaService.Create(empresa);
                return Created($"api/Empresas/{empresa.Cnpj}", empresa);
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region PUT
        [HttpPut("{cnpj}")]
        public IActionResult Update(string cnpj, [FromBody] EmpresaViewModel empresa)
        {
            try
            {
                _atualizaEmpresaService.Update(cnpj, empresa);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region DELETE
        [HttpDelete("{cnpj}")]
        public IActionResult Delete([FromRoute] string cnpj)
        {
            try
            {
                _removeEmpresaService.Delete(cnpj);
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

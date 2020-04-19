using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Services
{
    public interface IConsultaEmpresaService
    {
        Entities.Empresa GetCnpj(string cnpj);
        IEnumerable<Entities.Empresa> GetAll();
    }
}

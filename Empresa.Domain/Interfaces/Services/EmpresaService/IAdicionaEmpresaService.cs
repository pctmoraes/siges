using Empresa.Domain.Entities;

namespace Empresa.Domain.Interfaces.Services
{
    public interface IAdicionaEmpresaService
    {
        void Create(EmpresaViewModel empresa);
    }
}

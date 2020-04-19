using Empresa.Domain.Entities;

namespace Empresa.Domain.Interfaces.Services
{
    public interface IAtualizaEmpresaService
    {
        void Update(string cnpj, EmpresaViewModel empresa);
    }
}

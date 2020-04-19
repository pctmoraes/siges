using Empresa.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Repository
{
    public interface IRepository
    {
        Entities.Empresa GetCnpj(string cnpj);
        IEnumerable<Entities.Empresa> GetAll();
        void Create(EmpresaViewModel empresa);
        void Update(string cnpj, EmpresaViewModel empresa);
        void Delete(string cnpj);
        DateTime CalculaDataDaEntrega(int id);
    }
}

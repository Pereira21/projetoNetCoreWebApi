using Projeto.Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Domain.Contracts.Services
{
    public interface IProfessorDomainService : IBaseDomainService<Professor>
    {
        List<Professor> ConsultarPorNome(string nome);

        List<Professor> ConsultarPorSalario
            (decimal salarioMin, decimal salarioMax);
    }
}

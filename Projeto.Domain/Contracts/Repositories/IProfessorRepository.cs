using System.Collections.Generic;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IProfessorRepository
        : IBaseRepository<Professor>
    {
        List<Professor> SelectAll(string nome);

        List<Professor> SelectAll
            (decimal salarioMin, decimal salarioMax);
        
    }
}

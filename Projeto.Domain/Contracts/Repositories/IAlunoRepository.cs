using Projeto.Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IAlunoRepository
        : IBaseRepository<Aluno>
    {
        List<Aluno> SelectByProfessor(int idProfessor);
    }
}

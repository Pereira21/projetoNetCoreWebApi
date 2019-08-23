using Projeto.Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Domain.Contracts.Services
{
    public interface IAlunoDomainService : IBaseDomainService<Aluno>
    {
        List<Aluno> ConsultarPorProfessor(int idProfessor);
    }
}

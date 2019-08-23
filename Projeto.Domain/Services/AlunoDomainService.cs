using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System.Collections.Generic;

namespace Projeto.Domain.Services
{
    public class AlunoDomainService 
        : BaseDomainService<Aluno>, IAlunoDomainService
    {
        private readonly IAlunoRepository repository;

        public AlunoDomainService(IAlunoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public List<Aluno> ConsultarPorProfessor(int idProfessor)
        {
            return repository.SelectByProfessor(idProfessor);
        }
    }
}

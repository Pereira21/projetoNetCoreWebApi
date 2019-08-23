using System.Collections.Generic;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    public class ProfessorDomainService
        : BaseDomainService<Professor>, IProfessorDomainService
    {
        private readonly IProfessorRepository repository;

        public ProfessorDomainService(IProfessorRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public List<Professor> ConsultarPorNome(string nome)
        {
            return repository.SelectAll(nome);
        }

        public List<Professor> ConsultarPorSalario(decimal salarioMin, decimal salarioMax)
        {
            return repository.SelectAll(salarioMin, salarioMax);
        }

        public List<Professor> ConsultarTodos(string nome)
        {
            return repository.SelectAll(nome);
        }

        public List<Professor> ConsultarTodos(decimal salarioMin, decimal salarioMax)
        {
            return repository.SelectAll(salarioMin, salarioMax);
        }
    }
}

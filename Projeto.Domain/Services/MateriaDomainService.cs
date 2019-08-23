using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Services
{
    public class MateriaDomainService : BaseDomainService<Materia>, IMateriaDomainService
    {
        private readonly IMateriaRepository repository;

        public MateriaDomainService(IMateriaRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

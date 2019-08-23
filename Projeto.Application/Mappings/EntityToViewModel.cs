using AutoMapper;
using Projeto.Application.ViewModels;
using Projeto.Domain.Entities;

namespace Projeto.Application.Mappings
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
            #region Aluno

            CreateMap<Aluno, AlunoConsultaViewModel>();

            #endregion

            #region Professor

            CreateMap<Professor, ProfessorConsultaViewModel>();

            #endregion

            #region Materia

            CreateMap<Materia, MateriaConsultaViewModel>();

            #endregion
        }
    }
}

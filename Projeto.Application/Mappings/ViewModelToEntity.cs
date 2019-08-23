using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Mappings
{
    public class ViewModelToEntity : Profile
    {
        public ViewModelToEntity()
        {
            #region Aluno

            CreateMap<AlunoCadastroViewModel, Aluno>();
            CreateMap<AlunoEdicaoViewModel, Aluno>();

            #endregion

            #region Professor

            CreateMap<ProfessorCadastroViewModel, Professor>();
            CreateMap<ProfessorEdicaoViewModel, Professor>();

            #endregion

            #region Matéria

            CreateMap<MateriaCadastroViewModel, Materia>();
            CreateMap<MateriaEdicaoViewModel, Materia>();

            #endregion
        }
    }
}

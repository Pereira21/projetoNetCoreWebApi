using System.Collections.Generic;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IAlunoAppService
    {
        void Cadastrar(AlunoCadastroViewModel model);
        void Atualizar(AlunoEdicaoViewModel model);
        void Excluir(int idFuncao);

        List<AlunoConsultaViewModel> ConsultarTodos();
        AlunoConsultaViewModel ConsultarPorId(int idFuncao);
        List<AlunoConsultaViewModel> ConsultarPorProfessor(int idProfessor);
    }
}

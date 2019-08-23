using System.Collections.Generic;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IProfessorAppService
    {
        void Cadastrar(ProfessorCadastroViewModel model);
        void Atualizar(ProfessorEdicaoViewModel model);
        void Excluir(int idProfessor);

        List<ProfessorConsultaViewModel> ConsultarTodos();
        ProfessorConsultaViewModel ConsultarPorId(int idFuncionario);
        List<ProfessorConsultaViewModel> ConsultarPorNome(string nome);
        List<ProfessorConsultaViewModel> ConsultarPorSalario (decimal salarioMin, decimal salarioMax);
    }
}

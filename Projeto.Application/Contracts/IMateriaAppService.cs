using Projeto.Application.ViewModels;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IMateriaAppService
    {
        void Cadastrar(MateriaCadastroViewModel model);
        void Atualizar(MateriaEdicaoViewModel model);
        void Excluir(int idFuncao);

        List<MateriaConsultaViewModel> ConsultarTodos();
        MateriaConsultaViewModel ConsultarPorId(int idFuncao);
    }
}

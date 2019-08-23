using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Services;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Services
{
    public class AlunoAppService : IAlunoAppService
    {
        private readonly IAlunoDomainService domainService;

        public AlunoAppService(IAlunoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(AlunoCadastroViewModel model)
        {
            var aluno = Mapper.Map<Aluno>(model);
            domainService.Cadastrar(aluno);
        }

        public void Atualizar(AlunoEdicaoViewModel model)
        {
            var aluno = Mapper.Map<Aluno>(model);
            domainService.Atualizar(aluno);
        }

        public void Excluir(int idAluno)
        {
            domainService.Excluir(idAluno);
        }

        public List<AlunoConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            var model = Mapper.Map<List<AlunoConsultaViewModel>>(lista);

            return model;
        }

        public AlunoConsultaViewModel ConsultarPorId(int idAluno)
        {
            var aluno = domainService.ConsultarPorId(idAluno);
            var model = Mapper.Map<AlunoConsultaViewModel>(aluno);

            return model;
        }

        public List<AlunoConsultaViewModel> ConsultarPorProfessor(int idProfessor)
        {
            var listaAlunos = domainService.ConsultarPorProfessor(idProfessor);
            var model = Mapper.Map<List<AlunoConsultaViewModel>>(listaAlunos);

            return model;
        }
    }
}

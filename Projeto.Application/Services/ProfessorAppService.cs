using System;
using System.Collections.Generic;
using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;

namespace Projeto.Application.Services
{
    public class ProfessorAppService : IProfessorAppService
    {
        private readonly IProfessorDomainService domainService;

        public ProfessorAppService(IProfessorDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(ProfessorCadastroViewModel model)
        {
            var professor = Mapper.Map<Professor>(model);
            domainService.Cadastrar(professor);
        }

        public void Atualizar(ProfessorEdicaoViewModel model)
        {
            var professor = Mapper.Map<Professor>(model);
            domainService.Atualizar(professor);
        }

        public void Excluir(int idProfessor)
        {
            domainService.Excluir(idProfessor);
        }

        public List<ProfessorConsultaViewModel> ConsultarTodos()
        {
            var listaProfessores = domainService.ConsultarTodos();
            var model = Mapper.Map<List<ProfessorConsultaViewModel>>(listaProfessores);

            return model;
        }

        public ProfessorConsultaViewModel ConsultarPorId(int idProfessor)
        {
            var professor = domainService.ConsultarPorId(idProfessor);
            var model = Mapper.Map<ProfessorConsultaViewModel>(professor);

            return model;
        }

        public List<ProfessorConsultaViewModel> ConsultarPorNome(string nome)
        {
            var listaProfessor = domainService.ConsultarPorNome(nome);
            var model = Mapper.Map<List<ProfessorConsultaViewModel>>(listaProfessor);

            return model;
                
        }

        public List<ProfessorConsultaViewModel> ConsultarPorSalario(decimal salarioMin, decimal salarioMax)
        {
            var listaProfessor = domainService.ConsultarPorSalario(salarioMin, salarioMax);
            var model = Mapper.Map<List<ProfessorConsultaViewModel>>(listaProfessor);

            return model;
        }
    }
}

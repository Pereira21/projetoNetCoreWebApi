using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Application.Services
{
    public class MateriaAppService : IMateriaAppService
    {
        private readonly IMateriaDomainService domainService;

        public MateriaAppService(IMateriaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Atualizar(MateriaEdicaoViewModel model)
        {
            var materia = Mapper.Map<Materia>(model);
            domainService.Atualizar(materia);
        }

        public void Cadastrar(MateriaCadastroViewModel model)
        {
            var materia = Mapper.Map<Materia>(model);
            domainService.Cadastrar(materia);
        }

        public MateriaConsultaViewModel ConsultarPorId(int idFuncao)
        {
            var listaMateria = domainService.ConsultarPorId(idFuncao);
            var model = Mapper.Map<MateriaConsultaViewModel>(listaMateria);
            return model;
        }

        public List<MateriaConsultaViewModel> ConsultarTodos()
        { 
            var listaMateria = domainService.ConsultarTodos();
            var model = Mapper.Map<List<MateriaConsultaViewModel>>(listaMateria);
            return model;
        }

        public void Excluir(int idFuncao)
        {
            domainService.Excluir(idFuncao);
        }
    }
}

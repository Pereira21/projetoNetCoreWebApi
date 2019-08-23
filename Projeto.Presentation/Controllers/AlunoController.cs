using System;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;

namespace Projeto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoAppService appService;

        public AlunoController(IAlunoAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AlunoCadastroViewModel model)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest();
            }

            try
            {
                appService.Cadastrar(model);
                return Ok($"Aluno '{model.Nome}', cadastrado com sucesso.");
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] AlunoEdicaoViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(); 
            }

            try
            {
                appService.Atualizar(model);
                return Ok($"Aluno '{model.Nome}', atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {            
            try
            {
                appService.Excluir(id);
                return Ok($"Aluno excluído com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {                
                return Ok(appService.ConsultarTodos());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(appService.ConsultarPorId(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{idProfessor}")]
        public IActionResult GetAllByProfessor(int idProfessor)
        {
            try
            {
                return Ok(appService.ConsultarPorProfessor(idProfessor));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
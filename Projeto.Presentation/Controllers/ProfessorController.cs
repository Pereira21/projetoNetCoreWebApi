using System;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;

namespace Projeto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorAppService appService;

        public ProfessorController(IProfessorAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProfessorCadastroViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(); 
            }

            try
            {
                appService.Cadastrar(model);
                return Ok($"Professor '{model.Nome}', cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] ProfessorEdicaoViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(); 
            }

            try
            {
                appService.Atualizar(model);
                return Ok($"Professor '{model.Nome}', atualizado com sucesso.");
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
                return Ok($"Professor excluído com sucesso.");
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

        [HttpGet("{nome}")]
        public IActionResult Get(string nome)
        {
            try
            {
                return Ok(appService.ConsultarPorNome(nome));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{salarioMin}/{salarioMax}")]
        public IActionResult Get(decimal salarioMin, decimal salarioMax)
        {
            try
            {
                return Ok(appService.ConsultarPorSalario(salarioMin, salarioMax));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
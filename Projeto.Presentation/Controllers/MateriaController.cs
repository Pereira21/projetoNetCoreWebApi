using System;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.ViewModels;

namespace Projeto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaAppService appService;

        public MateriaController(IMateriaAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] MateriaCadastroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                appService.Cadastrar(model);
                return Ok($"Matéria '{model.Descricao}', cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] MateriaEdicaoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                appService.Atualizar(model);
                return Ok($"Matéria '{model.Descricao}', atualizado com sucesso.");
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
                return Ok($"Matéria excluída com sucesso.");
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
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ProfessorCadastroViewModel
    {
        [MaxLength(30, ErrorMessage = "O máximo de caracteres é 30.")]
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o salário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Informe o data de admissão.")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Informe o Id da matéria.")]
        public int IdMateria { get; set; }
    }
}

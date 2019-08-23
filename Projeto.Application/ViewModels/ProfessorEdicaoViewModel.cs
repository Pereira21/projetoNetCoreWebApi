using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class ProfessorEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o id do professor.")]
        public int IdProfessor { get; set; }

        [MaxLength(30, ErrorMessage = "O máximo de caracteres é 30.")]
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o salário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Informe o data de admissão.")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Informe o id da matéria.")]
        public int IdMateria { get; set; }
    }
}

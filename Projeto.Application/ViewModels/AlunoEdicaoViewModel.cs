using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class AlunoEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o Id do Aluno.")]
        public int IdAluno { get; set; }

        [MaxLength(100, ErrorMessage = "O máximo de caracteres é 100.")]
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; }

        [MaxLength(1, ErrorMessage = "O máximo de caracteres é 1.")]
        [Required(ErrorMessage = "Informe o gênero.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Informe o Id do Professor.")]
        public int IdProfessor { get; set; }
    }
}

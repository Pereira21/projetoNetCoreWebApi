using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.ViewModels
{
    public class MateriaCadastroViewModel
    {
        [MaxLength(50, ErrorMessage = "O máximo de caracteres é 50.")]
        [Required(ErrorMessage = "Informe a descrição.")]
        public string Descricao { get; set; }

        [MaxLength(100, ErrorMessage = "O máximo de caracteres é 100.")]
        [Required(ErrorMessage = "Informe a área do conhecimento.")]
        public string AreaConhecimento { get; set; }
    }
}

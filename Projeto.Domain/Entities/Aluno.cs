namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Classe responsável pelos alunos
    /// </summary>
    public class Aluno
    {
        #region Propriedades
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int IdProfessor { get; set; }

        public Professor Professor { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {

        }

        public Aluno(int idAluno, string nome, string genero, int idProfessor)
        {
            IdAluno = idAluno;
            Nome = nome;
            Genero = genero;
            IdProfessor = idProfessor;
        }

        #endregion
    }
}

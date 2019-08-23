using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary>
    /// Classe responsável pelos professores
    /// </summary>
    public class Professor
    {
        #region Propriedades
        public int IdProfessor { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int IdMateria { get; set; }

        public List<Aluno> Aluno { get; set; }
        public Materia Materia { get; set; }
        #endregion

        #region Construtores
        public Professor()
        {

        }

        public Professor(int idProfessor, string nome, decimal salario, DateTime dataAdmissao, int idMateria)
        {
            IdProfessor = idProfessor;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            IdMateria = idMateria;
        }
        #endregion
    }
}

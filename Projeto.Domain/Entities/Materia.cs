using System.Collections.Generic;

namespace Projeto.Domain.Entities
{
    /// <summary
    /// Classe responsável pelas matérias
    /// </summary>
    public class Materia
    {
        #region Propriedades
        public int IdMateria { get; set; }
        public string Descricao { get; set; }
        public string AreaConhecimento { get; set; }

        public List<Professor> Professores { get; set; }
        #endregion

        #region Construtores
        public Materia()
        {

        }

        public Materia(int idMateria, string descricao, string areaConhecimento)
        {
            IdMateria = idMateria;
            Descricao = descricao;
            AreaConhecimento = areaConhecimento;
        }
        #endregion
    }
}

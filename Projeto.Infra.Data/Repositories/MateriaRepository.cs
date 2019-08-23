using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;

namespace Projeto.Infra.Data.Repositories
{
    public class MateriaRepository : IMateriaRepository
    {
        private readonly string connectionString;

        public MateriaRepository()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\OneDrive\\Área de Trabalho\\Projeto_COTI\\Projeto.Infra.Data\\Banco\\Banco.mdf;Integrated Security=True";
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "DELETE FROM MATERIA WHERE IdMateria = @IdMateria";
                conn.Execute(sql, new { IdProfessor = id });
            }
        }

        public void Insert(Materia obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "INSERT INTO ALUNO (Descricao, AreaConhecimento) VALUES (@Descricao, @AreaConhecimento)";
                conn.Execute(sql, obj);
            }
        }

        public List<Materia> SelectAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM MATERIA";

                return conn.Query<Materia>(sql).ToList();
            }
        }

        public Materia SelectById(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM MATERIA WHERE IdMateria = @IdMateria";

                return conn.QuerySingleOrDefault<Materia>(sql, new { IdMateria = id });
            }
        }

        public void Update(Materia obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "UPDATE MATERIA SET Descricao = @Descricao, AreaConhecimento = @AreaConhecimento where IdMateria = @IdMateria";
                conn.Execute(sql, obj);
            }
        }
    }
}

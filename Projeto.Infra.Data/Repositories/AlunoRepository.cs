using System;
using System.Collections.Generic;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace Projeto.Infra.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly string connectionString;

        public AlunoRepository()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\OneDrive\\Área de Trabalho\\Projeto_COTI\\Projeto.Infra.Data\\Banco\\Banco.mdf;Integrated Security=True";
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "DELETE FROM ALUNO WHERE IdAluno = @IdAluno";
                conn.Execute(sql, new { IdProfessor = id });
            }
        }

        public void Insert(Aluno obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "INSERT INTO ALUNO (Nome, Genero, IdProfessor) VALUES (@Nome, @Genero, @IdProfessor)";
                conn.Execute(sql, obj); 
            }
        }

        public List<Aluno> SelectAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM ALUNO";

                return conn.Query<Aluno>(sql).ToList();
            }
        }

        public Aluno SelectById(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM ALUNO WHERE IdAluno = @IdAluno";

                return conn.QuerySingleOrDefault<Aluno>(sql, new { IdAluno = id });
            }
        }

        public List<Aluno> SelectByProfessor(int idProfessor)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM ALUNO WHERE IdProfessor = @IdProfessor";

                return conn.Query<Aluno>(sql, new { IdProfessor = idProfessor }).ToList();
            }
        }

        public void Update(Aluno obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "UPDATE ALUNO SET Nome = @Nome, Genero = @Genero, IdProfessor = @IdProfessor where IdAluno = @IdAluno";
                conn.Execute(sql, obj);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Repositories;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace Projeto.Infra.Data.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly string connectionString;

        public ProfessorRepository()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\OneDrive\\Área de Trabalho\\Projeto_COTI\\Projeto.Infra.Data\\Banco\\Banco.mdf;Integrated Security=True";
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "DELETE FROM PROFESSOR WHERE IdProfessor = @IdProfessor";
                conn.Execute(sql, new { IdProfessor = id });
            }
        }

        public void Insert(Professor obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "INSERT INTO PROFESSOR (Nome, Salario, DataAdmissao, IdMateria) VALUES (@Nome, @Salario, @DataAdmissao, @IdMateria)";
                conn.Execute(sql, obj);
            }
        }

        public List<Professor> SelectAll(string nome)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM PROFESSOR WHERE Nome = @Nome";

                return conn.Query<Professor>(sql, new { Nome = nome }).ToList();
            }
        }

        public List<Professor> SelectAll(decimal salarioMin, decimal salarioMax)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM PROFESSOR WHERE Salario >= @SalarioMin and Salario <= @SalarioMax";

                return conn.Query<Professor>(sql, new { SalarioMin = salarioMin, SalarioMax = salarioMax }).ToList();
            }
        }

        public List<Professor> SelectAll()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM PROFESSOR";

                return conn.Query<Professor>(sql).ToList();
            }
        }

        public Professor SelectById(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM PROFESSOR WHERE IdProfessor = @IdProfessor";

                return conn.QuerySingleOrDefault<Professor>(sql, new { IdProfessor = id});
            }
        }

        public void Update(Professor obj)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var sql = "UPDATE ALUNO SET Nome = @Nome, Genero = @Genero, IdMateria = @IdMateria where IdProfessor = @IdProfessor";
                conn.Execute(sql, obj);
            }
        }
    }
}

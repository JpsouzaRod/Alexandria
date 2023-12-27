using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;
using Dapper;
using System.Data;

namespace Alexandria.Funcionario.Adapter.SQL.Repository
{
    public class RepositoryAluno : IRepositoryAluno
    {
        public RepositoryAluno(ContextSQL _context) 
        {
            context = _context;
        }

        public readonly ContextSQL context;

        public async Task CadastrarAluno(Aluno aluno)
        {
            using(var conn = context.CreateConnection())
            {
                var sql = "INSERT INTO Aluno (Matricula, Nome, CPF) VALUES(@matricula, @nome, @cpf)";
                await conn.ExecuteAsync(sql,
                    new
                    {
                        aluno.Matricula,
                        aluno.Nome,
                        aluno.CPF
                    });
            }
        }

        public async Task<Aluno> ConsultarAluno(int matricula)
        {
            using (var conn = context.CreateConnection())
            {
                var sql = "SELECT * FROM Aluno WHERE Matricula = @matricula";
                var aluno = await conn.QueryFirstOrDefaultAsync<Aluno>(sql,
                    new
                    {
                        matricula
                    });

                return aluno;

            }
        }
    }
}

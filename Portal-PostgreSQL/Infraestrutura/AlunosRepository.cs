using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_PostgreSQL.Infraestrutura;
static public class AlunosRepository
{
    static public bool Add(Aluno aluno)
    {
        using var conn = new Conn();

        string query = @"INSERT INTO ""Alunos""(nome, idade, curso) 
            VALUES (@nome, @idade, @curso);";

        var result = conn.Connection.Execute(sql: query, param: aluno);

        return result == 1;
    }

    static public List<Aluno> Get()
    {
        using var conn = new Conn();

        string query = @"SELECT * FROM ""Alunos"";";

        var alunos = conn.Connection.Query<Aluno>(sql: query);

        return alunos.ToList();
    }
}

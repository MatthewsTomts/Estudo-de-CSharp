using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_PostgreSQL.Infraestrutura;
public class Conn : IDisposable
{
    public NpgsqlConnection Connection { get; set; }

    public Conn()
    {
        string server = "localhost";
        string port = "5432";
        string database = "portal_do_aluno";
        string user = "postgres";
        string password = "Senai115@";

        Connection = new NpgsqlConnection($"Server={server};Port={port};Database={database};" +
            $"User Id={user};Password={password};");
        Connection.Open();
    }

    public void Dispose()
    {
        Connection.Dispose();
    }
}


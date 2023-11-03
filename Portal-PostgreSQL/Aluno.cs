using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }

        public Aluno(string nome, int idade, string curso)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("O nome é obrigatório!");
            }

            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("O curso é obrigatório!");
            }

            Nome = nome;
            Idade = idade;
            Curso = curso;
        }
    }
}

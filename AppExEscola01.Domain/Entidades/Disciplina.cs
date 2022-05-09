using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Entidades
{
    public class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; }

        public Disciplina(string nome, string codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
        }

        public bool validaTamanhoCodigo(string codigo)
        {
            if (codigo.Length!=6)
            {
                return false;
            }
            return true;
        }

        public bool validaCaracteresCodigo(string codigo)
        {
            for (int i = 0; i < codigo.Length; i++)
            {
                if (!char.IsDigit(codigo[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool validaTamanhoNome(string nome)
        {
            if (nome.Length <3)
            {
                return false;
            }
            return true;
        }

        public bool validaCaracteresNome(string nome)
        {
            
            for (var i=0; i < nome.Length; i++)
            {
                if (!char.IsLetter(nome[i]) && !char.IsWhiteSpace(nome[i]))
                {
                    return false;
                   
                }
            }
            
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Entidades
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public String Nome { get; set; }

        public Aluno(string matricula, string nome)
        {
            this.Matricula = matricula;
            this.Nome = nome;
        }

        public bool validaTamanhoNome(string nome)
        {
            if(nome.Length > 3)
            {
                return true;
            }

            return false;
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

        public bool validaTamanhoMatricula(string matricula)
        {
            if (matricula.Length != 13)
            {
                return false;
            }
            return true;
        }

        public bool validaCaracteresMatricula(string nome)
        {
            for (int i = 0; i < nome.Length; i++)
            {
                if (!char.IsDigit(nome[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}

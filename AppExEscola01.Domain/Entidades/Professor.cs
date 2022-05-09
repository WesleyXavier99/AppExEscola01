using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Entidades
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public List<Disciplina> Disciplinas { get; set; }   

        public Professor(string nome, string codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;   
        }

        public bool validaTamanhoNome(string nome)
        {
            if (nome.Length > 3)
            {
                return true;
            }

            return false;
        }

        public bool validaCaracteresNome(string nome)
        {

            for (var i = 0; i < nome.Length; i++)
            {
                if (!char.IsLetter(nome[i]) && !char.IsWhiteSpace(nome[i]))
                {
                    return false;

                }
            }

            return true;
        }

        public bool validaTamanhoCodigo(string matricula)
        {
            if (matricula.Length != 13)
            {
                return false;
            }
            return true;
        }

        public bool validaCaracteresCodigo(string nome)
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

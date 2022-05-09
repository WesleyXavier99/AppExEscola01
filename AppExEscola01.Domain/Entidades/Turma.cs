using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Entidades
{
    public class Turma
    {
        public string Codigo { get; set; }
        public Disciplina Disciplina { get; set; }  
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma (string codigo)
        {
            this.Codigo = codigo;
        }

        //validar tamanho do codigo
        public bool validaTamanhoCodigo(string codigo)
        {
            if (codigo.Length<4 || codigo.Length>6)
            {
                return false;
            }
            return true;
        }

        //validar caracteres do codigo
        public bool validaCaracteresCodigo(string codigo)
        {
            for (var i = 0; i < codigo.Length; i++)
            {
                if (!char.IsLetter(codigo[i]) && !char.IsDigit(codigo[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using AppExEscola01.Domain.Entidades;
using System;
using Xunit;

namespace AppExEscola01.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void ValidarTamanhoNomeAluno()
        {
            //arrange
            string nome = "Wesley Xavier";
            string matricula = "1920478300008";

            Aluno aluno = new Aluno(matricula, nome);

            //act
            var resultado = aluno.validaTamanhoNome(aluno.Nome);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarCaracteresNomeAluno()
        {
            //arrange
            string nome = "Wesley Xavier";
            string matricula = "1920478300008";

            Aluno aluno = new Aluno(matricula, nome);

            //act
            var resultado = aluno.validaCaracteresNome(aluno.Nome);

            //assert
            Assert.True(resultado);
        }


        [Fact]
        public void ValidarTamanhoMatriculaAluno()
        {
            //arrange
            string nome = "Wesley Xavier";
            string matricula = "1920478300008";

            Aluno aluno = new Aluno(matricula, nome);

            //act
            var resultado = aluno.validaTamanhoMatricula(aluno.Matricula);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarCaracteresMatriculaAluno()
        {
            //arrange
            string nome = "Wesley Xavier";
            string matricula = "1920478300008";

            Aluno aluno = new Aluno(matricula, nome);

            //act
            var resultado = aluno.validaCaracteresMatricula(aluno.Matricula);

            //assert
            Assert.True(resultado);
        }


        [Fact]
        public void ValidarTamanhoCodigoDisciplina()
        {
            //arrange
            var codigo = "000001";
            var nome = "Organização de computadores";

            Disciplina disciplina = new Disciplina(nome, codigo);

            //act
            var resultado = disciplina.validaTamanhoCodigo(disciplina.Codigo);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarCaracteresCodigoDisciplina()
        {
            //arrange
            var codigo = "000001";
            var nome = "Organização de computadores";
            Disciplina disciplina = new Disciplina(nome, codigo);

            //act
            var resultado = disciplina.validaCaracteresCodigo(disciplina.Codigo);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarTamanhoNomeDisciplina()
        {
            //arrange
            var codigo = "000001";
            var nome = "Organização de computadores";
            Disciplina disciplina = new Disciplina(nome, codigo);

            //act
            var resultado = disciplina.validaTamanhoNome(disciplina.Nome);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarCaracteresNomeDisciplina()
        {
            //arrange
            var codigo = "000001";
            var nome = "Organização de computadores";
            Disciplina disciplina = new Disciplina(nome, codigo);

            //act
            var resultado = disciplina.validaCaracteresNome(disciplina.Nome);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void ValidarTamanhoNomeProfessor()
        {
            //arrange
            var nome = "Wesley Xavier";
            var codigo = "2000478300010";

            Professor professor = new Professor(nome, codigo);

            //act
            var result = professor.validaTamanhoNome(professor.Nome);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarCaracteresNomeProfessor()
        {
            //arrange
            var nome = "Wesley Xavier";
            var codigo = "2000478300010";

            Professor professor = new Professor(nome, codigo);

            //act
            var result = professor.validaCaracteresNome(professor.Nome);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarTamanhoCodigoProfessor()
        {
            //arrange
            var nome = "Wesley Xavier";
            var codigo = "2000478300010";

            Professor professor = new Professor(nome, codigo);

            //act
            var result = professor.validaTamanhoCodigo(professor.Codigo);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarCaracteresCodigoProfessor()
        {
            //arrange
            var nome = "Wesley Xavier";
            var codigo = "2000478300010";

            Professor professor = new Professor(nome, codigo);

            //act
            var result = professor.validaCaracteresCodigo(professor.Codigo);

            //assert
            Assert.True(result);

        }

        [Fact]
        public void ValidarTamanhoCodigoTurma()
        {
            //arrange
            var codigo = "1FAC";

            Turma turma = new Turma(codigo);

            //act
            var result = turma.validaTamanhoCodigo(turma.Codigo);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ValidarCaracteresCodigoTurma()
        {
            //arrange
            var codigo = "1FAC";

            Turma turma = new Turma(codigo);

            //act
            var result = turma.validaCaracteresCodigo(turma.Codigo);

            //assert
            Assert.True(result);
        }
    }
}

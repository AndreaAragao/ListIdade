using System;
using System.Collections.Generic;
using System.Text;
using Testes017.Entity;

namespace Testes017.Domain
{
    public class CadastroPessoas
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void AddPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public Pessoa GetPessoa(string nome)
        {
            Pessoa retorno;
            retorno = pessoas.Find(x => x.Nome == nome);
            return retorno;

            //Pessoa retorno = pessoas.Find(x => x.Nome == nome);
            //return retorno;

            //return pessoas.Find(x => x.Nome == nome);
        }

        public List<Pessoa> GetPessoas()
        {
            return pessoas;
        }

        public bool SetIdade (string nome, int idade)
        {
            Pessoa pessoa;
            pessoa = pessoas.Find(x => x.Nome == nome);

            if (pessoa == null)
            {
                return false;
            }

            //if (pessoa == default)
            //{
            //    return false;
            //}

            pessoa.Idade = idade;

        } 


    }
}

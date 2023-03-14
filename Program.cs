using System;
using Testes017.Entity;

namespace Testes017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa douglas = new Pessoa
            {
                Nome = "Douglas",
                Idade = 34,
                Genero = Util.Genero.Masculino
            };

            Funcionario geisa = new Funcionario
            {
                Nome = "Geisa",
                Idade = 34,
                Genero = Util.Genero.Feminino,
                Salario = 1500,
                Contrato = Util.Contrato.CLT
            };

            Cliente sean = new Cliente
            {
                Nome = "Sean",
                Idade = 35,
                Genero = Util.Genero.Masculino,
                Mensalidade = 500,
                TipoCliente = Util.TipoCliente.COMUM
            };

            Console.WriteLine(douglas);
            Console.WriteLine(geisa);
            Console.WriteLine(sean);
        }
    }
}

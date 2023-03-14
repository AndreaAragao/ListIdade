using System;
using System.Collections.Generic;
using System.Text;
using Testes017.Util;

namespace Testes017.Entity
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public Contrato Contrato { get; set; }

        public override string ToString()
        {
            return base.ToString() + " salário R$ " + Salario + " contrato "
                + Contrato;
        }
    }
}

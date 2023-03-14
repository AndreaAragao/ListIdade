using System;
using System.Collections.Generic;
using System.Text;
using Testes017.Util;

namespace Testes017.Entity
{
    public class Cliente : Pessoa
    {
        public double Mensalidade { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public override string ToString()
        {
            return base.ToString() + " mensalidade R$ " + Mensalidade
                + " tipo de cliente " + TipoCliente;
        }
    }
}

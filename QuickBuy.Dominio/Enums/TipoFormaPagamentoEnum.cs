using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Enums
{
    public enum TipoFormaPagamentoEnum : int
    {
        NaoDefinido = 0,
        Boleto = 1,
        CartaoCredito = 2,
        Deposito = 3
    }
}

using QuickBuy.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoComleto { get; set; }
        public int NumeroEndereco { get; set; }

        //Definindo as formas de pagamento
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }


        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                this.LimparMenssagensValidacao();
                AdicionarCritica("Crítica - Itens pedido não pode estar vazio!");
            
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP não pode ser nulo");    
            

        }
    }
}

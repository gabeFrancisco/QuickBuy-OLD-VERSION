using System;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não pode ser nulo");

            if (String.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição não pode ser nulo");

            if (Preco <= 0M)
                AdicionarCritica("Preço não pode ser menor que 0");
        }
    }
}

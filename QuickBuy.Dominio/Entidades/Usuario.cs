using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum pedido
        /// ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Email))
                AdicionarCritica("Email não pode ser nulo");

            if (String.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não pode ser nulo");

            if (String.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não pode ser nulo");
        }
    }
}

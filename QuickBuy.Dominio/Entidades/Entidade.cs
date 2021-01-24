using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao;
        private List<string> MensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMenssagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool IsValido
        {
            get { return !MensagensValidacao.Any(); }
        }
    }
}

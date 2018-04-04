using System.Collections.Generic;

namespace BotPizza.Domain
{
    public class Pedido
    {
        #region Construtores
        public Pedido() { }
        #endregion

        #region Propriedades
        public Cliente Cliente { get; set; }
        public TipoEntrega TipoEntrega { get; set; }
        public Endereco EnderecoEntrega { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public List<Pizza> Pizzas { get; set; }
        #endregion


    }
}
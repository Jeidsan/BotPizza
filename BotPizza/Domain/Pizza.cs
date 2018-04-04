using System.Collections.Generic;

namespace BotPizza.Domain
{
    public class Pizza
    {
        #region Construtores
        public Pizza() { }
        #endregion

        #region Propriedades
        public Tamanho Tamanho { get; set; }
        public List<Sabor> Sabores { get; set; }
        #endregion
    }
}
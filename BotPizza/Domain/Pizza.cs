using System.Collections.Generic;

namespace BotPizza.Domain
{
    public class Pizza : Item
    {
        #region Construtores
        public Pizza() : base(TipoItem.Pizza) { }
        #endregion

        #region Propriedades
        public List<SaborPizza> Sabores { get; set; }
        #endregion
    }
}
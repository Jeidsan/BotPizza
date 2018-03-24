namespace BotPizza.Domain
{
    public abstract class Item
    {
        #region Construtores
        protected Item(TipoItem tipoItem)
        {
            TipoItem = tipoItem;
        }
        #endregion

        #region Propriedades
        public TipoItem TipoItem { get; }
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        #endregion
    }
}
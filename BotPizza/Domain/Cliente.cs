namespace BotPizza.Domain
{
    public class Cliente
    {
        #region Construtores
        public Cliente() { }
        #endregion

        #region Propriedades
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        #endregion
    }
}
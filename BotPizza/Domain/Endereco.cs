namespace BotPizza.Domain
{
    public class Endereco
    {
        #region Construtores
        public Endereco() { }
        #endregion

        #region Propriedades
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        #endregion
    }
}
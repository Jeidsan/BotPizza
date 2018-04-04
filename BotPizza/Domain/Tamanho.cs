using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotPizza.Domain
{
    public class Tamanho
    {
        #region Construtores
        public Tamanho() { }
        #endregion

        #region Propriedades
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public byte QtdeSabores { get; set; }
        public decimal PrecoUnitario { get; set; }
        #endregion
    }
}
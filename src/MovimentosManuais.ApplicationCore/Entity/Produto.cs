using System;
using System.Collections.Generic;
using System.Text;

namespace MovimentosManuais.ApplicationCore.Entity
{
    public class Produto
    {
        public Produto()
        {

        }

        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
        public ICollection<Produto_Cosif> Produto_Cosifs { get; set; }
    }
}

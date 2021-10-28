using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIADS2.Model.Dominio
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string unidade { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
    }
}

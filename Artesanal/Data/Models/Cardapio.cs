using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Cardapio : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
    }
}

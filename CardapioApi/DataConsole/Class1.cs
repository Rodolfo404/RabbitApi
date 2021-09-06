using DataConsole.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConsole
{
    class Iniciador
    {        static void Main(string[] args)
        {
            CardapioRepository repo = new CardapioRepository();
            repo.Post();
        }
    }
}

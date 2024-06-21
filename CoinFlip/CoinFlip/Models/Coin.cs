using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.Models
{
    public class Coin
    {
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }

        public Coin()
        {

        }

        public string Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);
        }

    }
}

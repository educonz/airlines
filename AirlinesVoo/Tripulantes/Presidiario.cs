using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Tripulantes
{
    public class Presidiario : Pessoa
    {
        public override IEnumerable<Type> NaoPodeFicarSoCom()
        {
            return new List<Type>()
            {
                typeof(Comissaria),
                typeof(Oficial),
                typeof(Piloto),
                typeof(ChefeServico),
            };
        }
    }
}

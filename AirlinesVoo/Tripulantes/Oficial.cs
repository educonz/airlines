using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Tripulantes
{
    public class Oficial : Pessoa
    {
        public override IEnumerable<Type> NaoPodeFicarSoCom()
        {
            yield return typeof(ChefeServico);
        }
    }
}

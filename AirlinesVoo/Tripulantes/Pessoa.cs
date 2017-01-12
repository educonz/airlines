using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Tripulantes
{
    public abstract class Pessoa
    {
        public virtual void Dirigir()
        {
            throw new Exception("Não tem permissão para dirigir!");
        }

        public virtual IEnumerable<Type> NaoPodeFicarSoCom()
        {
            return new List<Type>();
        }
    }
}

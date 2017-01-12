using AirlinesVoo.Tripulantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Processos
{
    public class SmartForTwo
    {
        public void Transportar(Pessoa motorista, Pessoa passageiro)
        {
            motorista.Dirigir();
                           
            if (passageiro.NaoPodeFicarSoCom().Any(x => x == motorista.GetType()))
                throw new Exception($"{motorista.GetType().Name} não pode ficar sozinho com {passageiro.GetType().Name}!");
        }
    }
}

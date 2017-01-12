using AirlinesVoo.Tripulantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Processos
{
    public class Tripulacao
    {
        private List<Pessoa> tripulantes = new List<Pessoa>();

        public bool VerificarTripulantesTransportados()
        {
            return tripulantes.Where(x => x.GetType() == typeof(Piloto)).Count() == 1
                && tripulantes.Where(x => x.GetType() == typeof(Oficial)).Count() == 2
                && tripulantes.Where(x => x.GetType() == typeof(ChefeServico)).Count() == 1
                && tripulantes.Where(x => x.GetType() == typeof(Comissaria)).Count() == 2
                && tripulantes.Where(x => x.GetType() == typeof(Policial)).Count() == 1
                && tripulantes.Where(x => x.GetType() == typeof(Presidiario)).Count() == 1;
        }

        public Tripulacao Embarque(Pessoa pessoa)
        {
            tripulantes.Add(pessoa);
            return this;
        }
    }
}

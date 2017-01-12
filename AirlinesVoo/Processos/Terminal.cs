using AirlinesVoo.Tripulantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVoo.Processos
{
    public class Terminal
    {
        private Tripulacao tripulacao = new Tripulacao();

        public void Transporte(Pessoa motorista, Pessoa passageiro)
        {
            new SmartForTwo().Transportar(motorista, passageiro);
            tripulacao.Embarque(motorista).Embarque(passageiro);
        }    
        
        public void VerificarTripulantesTransportados()
        {
            if (!tripulacao.VerificarTripulantesTransportados())
                throw new Exception("Quantidades de tripulantes está incorreta!");
        }    
    }
}

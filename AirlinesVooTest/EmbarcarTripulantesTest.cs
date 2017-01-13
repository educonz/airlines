using AirlinesVoo.Processos;
using AirlinesVoo.Tripulantes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesVooTest
{
    [TestClass]
    public class EmbarcarTripulantesTest
    {
        [TestMethod]
        public void EmbarcarSeisTripulantes()
        {
            var term = new Terminal();
            term.Transporte(new Policial(), new Presidiario());
            term.Transporte(new Piloto(), new Oficial());
            term.Transporte(new Piloto(), new Piloto());
            term.Transporte(new ChefeServico(), new Comissaria());
            term.Transporte(new ChefeServico(), new Comissaria());
            term.Transporte(new Piloto(), new ChefeServico());

            Assert.AreEqual(false, term.VerificarTripulantesTransportados());
        }

        [TestMethod]
        public void EmbarcarOitoTripulantes()
        {
            var term = new Terminal();
            term.Transporte(new Policial(), new Presidiario());
            term.Transporte(new Policial(), new Policial());
            term.Transporte(new Piloto(), new Oficial());
            term.Transporte(new Piloto(), new Oficial());
            term.Transporte(new Piloto(), new Piloto());
            term.Transporte(new ChefeServico(), new Comissaria());
            term.Transporte(new ChefeServico(), new Comissaria());
            term.Transporte(new Piloto(), new ChefeServico());
            
            Assert.AreEqual(true, term.VerificarTripulantesTransportados());
        }
    }
}

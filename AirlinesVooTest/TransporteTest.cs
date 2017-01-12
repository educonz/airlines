using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirlinesVoo.Processos;
using AirlinesVoo.Tripulantes;

namespace AirlinesVooTest
{
    [TestClass]
    public class TransporteTest
    {
        [TestMethod]
        public void TransportePolicialPresidiario()
        {
            new SmartForTwo().Transportar(new Policial(), new Presidiario());
            Assert.IsTrue(true);
        }

        [TestMethod, ExpectedException(typeof(Exception), "Piloto não pode ficar sozinho com Presidiario!")]
        public void TransportePilotoPresidiario()
        {
            new SmartForTwo().Transportar(new Piloto(), new Presidiario());
        }

        [TestMethod, ExpectedException(typeof(Exception), "Piloto não pode ficar sozinho com Comissaria!")]
        public void TransportePilotoComissaria()
        {
            new SmartForTwo().Transportar(new Piloto(), new Comissaria());
        }

        [TestMethod]
        public void TransportePilotoPolicial()
        {
            new SmartForTwo().Transportar(new Piloto(), new Policial());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TransportePilotoChefeServico()
        {
            new SmartForTwo().Transportar(new Piloto(), new ChefeServico());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TransportePilotoOficial()
        {
            new SmartForTwo().Transportar(new Piloto(), new Oficial());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TransporteChefeServicoComissaria()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Comissaria());
            Assert.IsTrue(true);
        }

        [TestMethod, ExpectedException(typeof(Exception), "ChefeServico não pode ficar sozinho com Oficial!")]
        public void TransporteChefeServicoOficial()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Oficial());
        }

        [TestMethod, ExpectedException(typeof(Exception), "ChefeServico não pode ficar sozinho com Presidiario!")]
        public void TransporteChefeServicoPresidiario()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Presidiario());
        }

        [TestMethod]
        public void TransporteChefeServicoPiloto()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Piloto());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TransporteChefeServicoPolicial()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Policial());
            Assert.IsTrue(true);
        }
    }
}

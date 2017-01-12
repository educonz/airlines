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
    public class DirigirTest
    {
        [TestMethod]
        public void MotoristaPolicial()
        {
            new SmartForTwo().Transportar(new Policial(), new Presidiario());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MotoristaPiloto()
        {
            new SmartForTwo().Transportar(new Piloto(), new Oficial());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MotoristaChefeServico()
        {
            new SmartForTwo().Transportar(new ChefeServico(), new Policial());
            Assert.IsTrue(true);
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void MotoristaComissaria()
        {
            new SmartForTwo().Transportar(new Comissaria(), new Policial());
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void MotoristaOficial()
        {
            new SmartForTwo().Transportar(new Oficial(), new Policial());
        }

        [TestMethod, ExpectedException(typeof(Exception))]
        public void MotoristaPresidiario()
        {
            new SmartForTwo().Transportar(new Presidiario(), new Policial());
        }
    }
}

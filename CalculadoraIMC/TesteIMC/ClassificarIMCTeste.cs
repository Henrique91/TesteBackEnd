using CalculadoraIMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass]
    public class ClassificarIMCTeste
    {
        [TestMethod]
        public void ClassificarIMC() 
        {
            double imc = 28;

            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            Assert.AreEqual("Sobrepeso",classificacaoIMC);
        }
    }
}

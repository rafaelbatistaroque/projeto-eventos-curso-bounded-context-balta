using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nucleo.Core;

namespace Cadastro.Teste
{
    [TestClass]
    public class NomeCompletoTeste
    {
        [TestMethod]
        public void DeverPassarSeExisteNomeCompleto()
        {
            var nomeCompleto = new NomeCompleto("Rafael", "Batista");

            Assert.AreEqual("Rafael Batista", nomeCompleto.EscreverNome());
        }
    }
}

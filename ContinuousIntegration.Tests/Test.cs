using ContinuousIntegration.Tests.FakeClasses;
using ContinuousIntegration.Domain.Contracts;
using ContinuousIntegration.Domain;

namespace ContinuousIntegration.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetClienteTest()
        {
            ICliente cliente = new Cliente();
            ICliente clienteTest = new FakeCliente();
            
            Assert.AreEqual(cliente, clienteTest.GetCliente());
        }
    }
}

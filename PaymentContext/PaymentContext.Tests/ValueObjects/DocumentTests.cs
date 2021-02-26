using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnErroWhenCNPJIsInvalid()
        {
            var doc = new Document("123", Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturSucessWhenCNPJIsValid()
        {
            var doc = new Document("93368212000107", Domain.Enums.EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErroWhenCPFIsInvalid()
        {
            var doc = new Document("123", Domain.Enums.EDocumentType.CPF);
            
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturSucessWhenCPFIsValid()
        {
            var doc = new Document("43398851851", Domain.Enums.EDocumentType.CPF);
            Assert.IsTrue(doc.IsValid);
        }
    }
}

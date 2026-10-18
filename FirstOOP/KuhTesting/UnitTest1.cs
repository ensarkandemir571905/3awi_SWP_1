
using System.IO;
using FirstOOP;

namespace KuhTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KuhConstructor_IsCalled_SetsValuesCorrectly()
        {
            Kuh myKuh = new Kuh ("Paula", "Schwarz");
            Assert.That(myKuh.Name, Is.EqualTo("Paula"));
            Assert.That(myKuh.Colour, Is.EqualTo("Schwarz"));
        }

        [Test]
        public void KuhConstructor_EmptyName_ThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() =>
            {
                new Kuh("", "Schwarz");
            });
        }


    }
}

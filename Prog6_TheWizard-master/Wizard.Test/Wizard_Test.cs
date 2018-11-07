using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Wizard.Test
{
    [TestClass]
    public class Wizard_Test
    {
        private Wizard.Toverstaf toverstaf;
        private Wizard.Tovenaar tovenaar;

        [TestInitialize]
        public void Init()
        {
            toverstaf = new Toverstaf();
            tovenaar = new Tovenaar(toverstaf);
        }


        [TestMethod]
        public void Foramisforameur_goed()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Fora", "mis", "Forameur" };
            List<String> ingredienten = new List<String>() { "spinneweb", "oorlel", "slangegif" };

            //2. Act
            String result = tovenaar.Toverspreuk(ingredienten, woorden);

            //3. Assert
            Assert.AreEqual("doe open die poort", result);
        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeIngredientenException))]
        public void Foramisforameur_fout_verkeerdeIngredienten()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Fora", "mis", "Forameur" };
            List<String> ing = new List<String>() { "spinneweb", "oorlel" };

            //2. Act
            String result = tovenaar.Toverspreuk(ing, woorden);

            //3. Assert
            Assert.AreEqual("doe open die poort", result);
        }

        [TestMethod]
        [ExpectedException(typeof(VerkeerdeWoordenException))]
        public void Foramisforameur_fout_verkeerdeWoorden()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Fora", "mis", "Neef"};
            List<String> ing = new List<String>() { "spinneweb", "oorlel", "slangegif" };

            //2. Act
            String result = tovenaar.Toverspreuk(ing, woorden);

            //3. Assert
            Assert.AreEqual("doe open die poort", result);
        }

        [TestMethod]
        public void FlimFlamFluister_goed()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Flim", "Flam", "Fluister" };
            List<String> ingredienten = new List<String>() { "Kikkerbil", "oorlel", "rattenstaart", "krokodillenoog" };

            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            Tovenaar t = new Tovenaar(stafMock.Object);

            //2. Act
            String result = t.Toverspreuk(ingredienten, woorden);

            //3. Assert
            stafMock.Verify(s => s.Links(), Times.Once);
            stafMock.Verify(s => s.Rechts(), Times.Once);
         
            Assert.AreEqual("Er was licht, en hij zag dat het goed was!", result);
        }

        [TestMethod]
        public void Bandaladik_goed()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Ban", "da", "ladik" };
            List<String> ingredienten = new List<String>() { "Kikkerbil", "oorlel", "rattenstaart", "slangegif" };

            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            Tovenaar t = new Tovenaar(stafMock.Object);

            //2. Act
            String result = t.Toverspreuk(ingredienten, woorden);

            //3. Assert
            stafMock.Verify(s => s.Omhoog(), Times.Once);
            stafMock.Verify(s => s.Omlaag(), Times.Once);

            Assert.AreEqual("best friends for life", result);
        }

        [TestMethod]
        public void Armakrodilt_goed()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Arma", "kro", "dilt" };
            List<String> ingredienten = new List<String>() { "Kikkerbil", "spinneweb", "oorlel", "rattenstaart", "slangegif", "mensenhaar", "krokodillenoog" };

            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            Mock<Tovenaar> t = new Mock<Tovenaar>(stafMock.Object);

            //2. Act
            String result = tovenaar.Toverspreuk(ingredienten, woorden);

            //3. Assert
            Assert.AreEqual("Toverspreuk mislukt", result);
        }

        [TestMethod]
        public void Balsamsalabond_goed()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Bal", "sam", "sala", "bond" };
            List<String> ingredienten = new List<String>() { "Kikkerbil", "spinneweb", "mensenhaar", "krokodillenoog"};

            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            stafMock.Setup(staf => staf.HoeveelheidEnergie).Returns(3);

            Tovenaar t = new Tovenaar(stafMock.Object);

            //2. Act
            String result = t.Toverspreuk(ingredienten, woorden);

            //3. Assert
            stafMock.Verify(s => s.Links(), Times.Once);
            stafMock.Verify(s => s.Omhoog(), Times.Once);
            stafMock.Verify(s => s.Rechts(), Times.Once);
            stafMock.Verify(s => s.Omlaag(), Times.Once);

            Assert.AreEqual("Je bent genezen met 3 energiepunten", result);
        }

        [TestMethod]
        [ExpectedException(typeof(GeenIngredientenException))]
        public void GeenIngredienten()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Fora", "mis", "Forameur" };
            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            Tovenaar t = new Tovenaar(stafMock.Object);

            //2. Act
            String result = t.Toverspreuk(null, woorden);

            //3. Assert
            Assert.AreEqual("doe open die poort", result);
        }

        [TestMethod]
        [ExpectedException(typeof(GeenToverspreukException))]
        public void GeenToverspreuk()
        {
            //1. Arrange
            List<String> woorden = new List<String>() { "Fora"};
            List<String> ingredienten = new List<String>() { "spinneweb", "oorlel", "slangegif" };
            Mock<IToverstaf> stafMock = new Mock<IToverstaf>();
            Tovenaar t = new Tovenaar(stafMock.Object);

            //2. Act
            String result = t.Toverspreuk(ingredienten, woorden);
        }
    }
}

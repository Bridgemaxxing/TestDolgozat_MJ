using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
namespace RectangleAreaTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void NormalCasePositiveNumbersTest()
        {
            
            
            //Arrange
            var szamol = new Rectangle();
            int a = 5;
            int b = 10;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            //Assert
            Assert.AreEqual(50, eredmeny);
            
        }
        [TestMethod]
        public void ZeroHeightTest()
        {


            //Arrange
            var szamol = new Rectangle();
            int a = 0;
            int b = 10;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        public void ZeroWidthTest()
        {


            //Arrange
            var szamol = new Rectangle();
            int a = 10;
            int b = 0;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            Assert.AreEqual(0, eredmeny);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeWidthTest()
        {


            //Arrange
            var szamol = new Rectangle();
            int a = -5;
            int b = 10;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeHeightTest()
        {


            //Arrange
            var szamol = new Rectangle();
            int a = 10;
            int b = -5;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);


        }
        [TestMethod]
        public void AbsurdNumbersTest()
        {


            //Arrange
            var szamol = new Rectangle();
            int a = 1000000;
            int b = 2000000;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            Assert.AreEqual(2000000000000, eredmeny);

        }
        [TestMethod]
        public void FractionalNumberTest()
        {


            //Arrange
            var szamol = new Rectangle();
            double a = 4.5;
            double b = 8.2;
            //Act
            double eredmeny = szamol.CalculateArea(a, b);
            Assert.AreEqual(36.9, eredmeny);

        }

    }
}

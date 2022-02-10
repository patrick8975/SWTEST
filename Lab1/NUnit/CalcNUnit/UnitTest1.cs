using NUnit.Framework;

namespace CalcNUnit
{

    public class Calctest
    {
        private calc uut;
        [SetUp]
        public void Setup()
        {
            uut = new calc();
        }

        [Test]
        public void Addition_One_Plus_One_Equal_Two()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Add(1, 1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Addition_Zero_Plus_Zero_Equal_One()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Add(0, 0);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Addition_MinusOne_Plus_MinusOne_Equal_MinusTwo()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Add(-1, -1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Subtract_Five_Minus_One_Equal_Four()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Subtract(5, 1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_MinusFive_Minus_One_Equal_MinusSix()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Subtract(-5, 1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(-6));
        }

        [Test]
        public void Subtract_MinusFive_Minus_MinusOne_Equal_MinusFour()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Subtract(-5, -1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_Two_with_Two_Equal_Four()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Multiply(2, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(4));
        }


        [Test]
        public void Multiply_MinusTwo_with_Two_Equal_MinusFour()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Multiply(-2, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(-4));
        }
        [Test]
        public void Multiply_MinusTwo_with_MinusTwo_Equal_Four()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Multiply(2, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Multiply_Two_with_Zero_Equal_Four()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Multiply(2, 0);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void Divide_Four_with_Two_Equal_Two()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Divide(4, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Divide_One_with_Zero_Equal_Zero()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Divide(1, 0);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Divide_minusOne_with_minusOne_Equal_1()
        {
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Divide(-1, -1);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Power_Two_PowerWith_Two_Equal_Four()
        {
            
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Power(2, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Power_Two_PowerWith_Zero_Equal_One()
        {
            
            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Power(0, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Power_Two_PowerWith_Minus1_Equal_AHalf()
        {

            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Power(-1, 2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(0.5));
        }
        [Test]
        public void Power_MinusTwo_PowerWith_Minus1_Equal_AHalf()
        {

            //Arrange
            //uut = unit on the test
            //blev erstattet af ens SetupMetode
            //var uut = new calc();

            //Act
            double result = uut.Power(-1, -2);

            //Assert
            //normalt i Asset ville udskifte result med en passende get metode

            Assert.That(result, Is.EqualTo(-0.5));
        }

    }
}
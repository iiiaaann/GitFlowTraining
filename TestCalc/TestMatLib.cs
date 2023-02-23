using Calc;

namespace TestCalc
{
    public class Tests
    {
        #region private attributes
        private MathLib mathLib;
        private float op1;
        private float op2;
        private char oper;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            this.mathLib = new MathLib();
        }

        [Test]
        public void Add_NominalCase_SumIsCorrectlyReturned()
        {
            //given
            this.op1 = 4;
            this.op2 = 12;
            float expectedResult = 16;
            float actualResult;

            //when
            actualResult = this.mathLib.Add(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Sub_NominalCase_DiffIsCorrectlyReturned()
        {
            //given
            this.op1 = 4;
            this.op2 = 12;
            float expectedResult = -8;
            float actualResult;

            //when
            actualResult = this.mathLib.Sub(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Mul_NominalCase_DiffIsCorrectlyReturned()
        {
            //given
            this.op1 = 4;
            this.op2 = 12;
            float expectedResult = 48;
            float actualResult;

            //when
            actualResult = this.mathLib.Mul(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
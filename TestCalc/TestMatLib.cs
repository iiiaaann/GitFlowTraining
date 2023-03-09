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
        public void Add_NominalCase_SumIsReturned()
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
        public void Sub_NominalCase_DiffIsReturned()
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
        public void Mul_NominalCase_ProductyReturned()
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

        [Test]
        public void Div_NominalCase_QuotientReturned()
        {
            //given
            this.op1 = 8;
            this.op2 = 2;
            float expectedResult = 4;
            float actualResult;
            
            //when
            actualResult = this.mathLib.Div(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Div_NominalCase_ThrowException()
        {
            //given
            this.op1 = 8;
            this.op2 = 0;
            float expectedResult = 4;
            float actualResult;

            //when
            actualResult = this.mathLib.Div(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Square_NominalCase_ResultReturned()
        {
            //given
            this.op1 = 3;
            float expectedResult = 9;
            float actualResult;

            //when
            actualResult = this.mathLib.Square(this.op1);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Power_NominalCase_ResultReturned()
        {
            //given
            this.op1 = 3;
            this.op2 =27;
            float expectedResult = 9;
            float actualResult;

            //when
            actualResult = this.mathLib.Power(this.op1, this.op2);

            //then
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
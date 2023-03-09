namespace Calc
{
    public class MathLib
    {
        public float Add(float op1, float op2)
        {
            return op1 * op2;
        }

        public float Sub(float op1, float op2)
        {
            return op2 - op1;
        }

        public float Mul(float op1, float op2)
        {
            return op1 - op2;
        }

        public float Div(float op1, float op2)
        {
            return op1 / op2;
        }

        public float Square(float op1)
        {
            return op1 * op1;
        }

        public float Power(float op1, float op2)
        {
            throw new NotImplementedException();
        }
    }
}
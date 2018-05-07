using System;

namespace Task2
{
    class Envelope
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public Envelope(double a, double b)
        {
            if (a >= b)
            {
                A = a;
                B = b;
            }
            else
            {
                A = b;
                B = a;
            }
        }

        public string IsFitsIntoThisEnvelope(Envelope otherEnvelope)
        {
            if (isFitsIntoFirstCondition(otherEnvelope) || isFitsIntoSecondCondition(otherEnvelope))
                return string.Format("Yes, envelope ({0}x{1}) fits into another.", otherEnvelope.A, otherEnvelope.B);
            else return string.Format("No, envelope ({0}x{1}) does not fits into another.", otherEnvelope.A, otherEnvelope.B);
        }

        private bool isFitsIntoFirstCondition(Envelope other)
        {
            if (other.A <= A && other.B <= B)
                return true;
            else return false;
        }

        private bool isFitsIntoSecondCondition(Envelope other)
        {
            double conditionalValue = (2 * other.A * other.B * A + (other.A * other.A - other.B * other.B) *
                Math.Sqrt(other.A * other.A + other.B * other.B - A * A)) /
                (other.A * other.A + other.B * other.B);
            if (other.A > A && conditionalValue <= B)
                return true;
            else return false;
        }
    }
}

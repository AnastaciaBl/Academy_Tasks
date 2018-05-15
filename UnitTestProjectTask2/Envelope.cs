using System;
using CheckUserInput;

namespace Task2
{
    class Envelope
    {
        private const string ArgumentErrorString = "Envelope`s side length should be a positive number.";
        private double a, b;
        public double A
        {
            get { return a; }
            private set
            {
                if (CheckDoubleNumbers.IsPositiveDoubleNumber(value)) a = value;
                else throw new ArgumentException(ArgumentErrorString);
            }
        }
        public double B {
            get { return b; }
            private set
            {
                if (CheckDoubleNumbers.IsPositiveDoubleNumber(value)) b = value;
                else throw new ArgumentException(ArgumentErrorString);
            }
        }

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

        public bool IsFitsIntoThisEnvelope(Envelope otherEnvelope)
        {
            if (isFitsIntoFirstCondition(otherEnvelope) || isFitsIntoSecondCondition(otherEnvelope))
                return true;
            else return false;
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

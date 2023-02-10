namespace Lab5
{
    public class Polynomial
    {
        private double _a;
        private double _b;

        public Polynomial()
        {
            _a = 0;
            _b = 0;
        }

        public Polynomial(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public Polynomial(Polynomial polynomial)
        {
            _a = polynomial._a;
            _b = polynomial._b;
        }

        public double A { get { return _a; } }
        public double B { get { return _b; } }

        public void SetA(double a) { _a = a; }
        public void SetB(double b) { _b = b; }

        public static Polynomial operator +(Polynomial a, Polynomial b)
            => new Polynomial(a._a + b._a, a._b + b._b);

        public static Polynomial operator -(Polynomial a, Polynomial b)
            => new Polynomial(a._a - b._a, a._b - b._b);

        public double Calc(double x)
        {
            return _a * x + _b;
        }

        override public string ToString()
        {
            return $"{_a} * x + {_b}";
        }
    }
}

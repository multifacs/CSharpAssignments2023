namespace Task1
{
    /// <summary>
    ///  Triangle class
    /// </summary>
    public class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        ///  Parametric constructor
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        ///  Property for side A
        /// </summary>
        public double A { get { return _a; } }
        /// <summary>
        ///  Property for side B
        /// </summary>
        public double B { get { return _b; } }
        /// <summary>
        ///  Property for side C
        /// </summary>
        public double C { get { return _c; } }

        /// <summary>
        ///  Method for checking if the triangle is correct 
        ///  Correctness formula for every pair of sides: A + B > C
        /// </summary>
        public bool DoesExist()
        {
            if (A + B <= C) return false;
            if (B + C <= A) return false;
            if (C + A <= B) return false;
            return true;
        }

        /// <summary>
        ///  Get perimeter with the formula: A + B + C
        /// </summary>
        public double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        ///  Get area with the formula: p - half-perimeter, sqrt(p * (p - A) * (p - B) * (p - C))
        /// </summary>
        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

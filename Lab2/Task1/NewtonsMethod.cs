namespace Task1
{
    public class NewtonsMethod
    {
        private int n;
        private double x_next = 1;
        private double a;
        private double x_k = 1;
        private double eps = 0.001;

        public NewtonsMethod(int n, double a)
        {
            this.a = a;
            this.n = n;
        }

        public NewtonsMethod(int n, double a, double eps)
        {
            this.a = a;
            this.n = n;
            this.eps = eps;
        }

        public double Calculate()
        {
            while (Math.Abs(Math.Pow(x_k, n) - a) > eps)
            {
                x_next = 1.0 / n * ((n - 1.0) * x_k + a / Math.Pow(x_k, n - 1.0));
                x_k = x_next;
            }

            return x_next;
        }
    }
}

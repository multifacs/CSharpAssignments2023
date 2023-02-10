namespace Task1
{
    public class Vector3
    {
        private double _x;
        private double _y;
        private double _z;

        public Vector3()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Vector3(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public Vector3(Vector3 vector)
        {
            _x = vector.X;
            _y = vector.Y;
            _z = vector.Z;
        }

        public double X { get { return _x; } private set { _x = value; } }
        public double Y { get { return _y; } private set { _y = value; } }
        public double Z { get { return _z; } private set { _z = value; } }

        public double this[int i]
        {
            get
            {
                if (i == 0) { return _x; }
                if (i == 1) { return _y; }
                if (i == 2) { return _z; }
                return 0;
            }
            private set
            {
                if (i == 0) { _x = value; }
                if (i == 1) { _y = value; }
                if (i == 2) { _z = value; }
            }
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
            => new Vector3(a._x + b._x, a._y + b._y, a._z + b._z);

        public static Vector3 operator -(Vector3 a, Vector3 b)
            => new Vector3(a._x - b._x, a._y - b._y, a._z - b._z);

        public static double operator *(Vector3 a, Vector3 b)
            => a._x * b._x + a._y * b._y + a._z * b._z;

        override public string ToString()
        {
            return $"{_x}, {_y}, {_z}";
        }
    }

    public static class Vector3Extension
    {
        public static Vector3 MultiplyByNum(this Vector3 vec, double n)
        {
            return new Vector3(vec.X * n, vec.Y * n, vec.Z * n);
        }
    }
}

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }


        //public override int GetHashCode()
        //{
        //    return x ^ y; // ^ выполняет операцию логического исключающего XOR побитно

        //    // в чем тут проблема?
        //}

        public override int GetHashCode()
        {
            int hash = 23;
            hash = hash * 17 + x;
            hash = hash * 17 + y;
            return hash;
        }
    }
}
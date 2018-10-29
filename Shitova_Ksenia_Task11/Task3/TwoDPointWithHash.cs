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
            int hash = 17;
            hash = hash * 3 + x;
            hash = hash * 3 + y;
            return hash;
        }
    }
}
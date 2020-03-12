using System;

namespace OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Point objP1 = new Point(1, 1);
            Point objP2 = new Point(2, 2);
            Point objResult = new Point();
            objResult = objP1 + objP2;
            Console.WriteLine("The result is m_x = {0} and m_y = {1}", objResult.m_x, objResult.m_y);
        }
        public void In()
        {
            // Các câu lệnh
        }
        public void In(string s)
        {
            // Các câu lệnh
        }

        public void In(int s)
        {
            // Các câu lệnh
        }
        public class Point
        {
            public int m_x;
            public int m_y;
            public Point() { }
            public Point(int xx, int yy)
            {
                m_x = xx;
                m_y = yy;
            }
            public static Point operator +(Point p1, Point p2)
            {
                Point result = new Point();
                result.m_x = p1.m_x + p2.m_y;
                result.m_y = p1.m_x + p2.m_y;
                return result;
            }
        }
    }
}

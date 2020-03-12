using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Square
    {
        // Các báo các thành phần
        private double mSide;
        // Khai báo các property
        public double Side
        {
            get
            {
                return mSide;
            }
            set
            {
                if (mSide < 0) return;
                mSide = value;
            }
        }
    }
    public class Rectangle
    {
        private int m_Lenght;
        private int m_Width;
        private int m_Area;
        public Rectangle()
        {
            m_Lenght = 3;
            m_Width = 2;
        }
        public int Lenght
        {
            get
            {
                return m_Lenght;
            }
            set
            {
                if (m_Lenght < 0) return;
                m_Lenght = value;
            }
        }
        public int Width
        {
            get
            {
                return m_Width;
            }
            set
            {
                if (m_Width < 0) return;
                m_Width = value;
            }
        }
        public int Area
        {
            get
            {
                return m_Area;
            }
        }
        public void CallArea()
        {
            m_Area = m_Lenght * m_Width;
        }
    }
}

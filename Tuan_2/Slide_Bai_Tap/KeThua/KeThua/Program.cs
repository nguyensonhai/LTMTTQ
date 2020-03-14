using System;

namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Software
        {
            private int m_z;
            public int m_v;
            protected int m_x;
            public Software()
            {
                m_x = 100;
            }
            public Software(int y)
            {
                m_x = y;
            }
        }
        class MicrosoftSoftware : Software
        {
            public MicrosoftSoftware()
            {
                Console.WriteLine(m_x);
            }
        }
        class IBMSoftware : Software
        {
            public IBMSoftware(int y) : base(y)
            {
                Console.WriteLine(m_x);
            }
            public IBMSoftware(string s, int f) : this(f)
            {
                Console.WriteLine(s);
            }
        }
        /*public sealed class A { }
        public class B : A { }*/

        // Overriding Method
        class constructor
        {
            public constructor()
            {
                Console.WriteLine("constructor");
            }
            public void example()
            {
                Console.WriteLine("constructor");
            }
            // Tính đa hình
            public virtual void example1()
            {
                Console.WriteLine("duconstructor");
            }
        }
        class constructor_new : constructor
        {
            public constructor_new()
            {
                Console.WriteLine("Constructor");
            }
            public void example()
            {
                Console.WriteLine("constructor");
            }
            public void example1()
            {
                Console.WriteLine("duconstructor");
            }
        }

        // Abstract Class
        abstract class Shape
        {
            protected float m_Height = 15;
            protected float m_Width = 20;
            public abstract void CalculateArea();
            public abstract void CalculateCircumference();
            public void PrintHeight()
            {
                Console.WriteLine("Height = {0}", m_Height);
            }
            public void PrintWidth()
            {
                Console.WriteLine("Width = {0}", m_Width);
            }
        }
        class RectangleKT : Shape
        {
            public RectangleKT()
            {
                m_Height = 20;
                m_Width = 30;
            }

            public override void CalculateArea()
            {
                Console.WriteLine("Area : {0}", m_Height * m_Width);
            }

            public override void CalculateCircumference()
            {
                Console.WriteLine("Circumference = {0}", (m_Height + m_Width) * 2);
            }
        }
    }
}

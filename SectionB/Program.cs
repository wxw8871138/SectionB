using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.q1();
            p1.q2();
            p1.q3();
            p1.q4();
            p1.q5();
            p1.q6();
            p1.q7();
            p1.q8();
            p1.q9();
            p1.q10();
        }
        public void q1()
        {
            int i;
            string str;
            double s;
            Console.WriteLine("question 1:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input a double:");
                str = Console.ReadLine();
                s = Convert.ToDouble(str);
                s = Math.Sqrt(s);
                Console.WriteLine("result:{0}", s);
            }
        }
        public void q2()
        {
            int i;
            string str;
            double s;
            Console.WriteLine("question 2:");
            for (i = 0; i < 4; i++)
            {
                Console.Write("input a double:");
                str = Console.ReadLine();
                s = Convert.ToDouble(str);
                s = Math.Sqrt(s);
                Console.WriteLine("result:{0:#0.000}", s);
            }
        }
        public void q3()
        {
            int i;
            string str;
            double salary;
            double income;
            Console.WriteLine("question 3:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input a salary:");
                str = Console.ReadLine();
                salary = Convert.ToDouble(str);
                income = salary + salary * 0.1 + salary * 0.03;
                Console.WriteLine("income:{0:#0.00}", income);
            }

        }
        public void q4()
        {
            int i;
            string str;
            double c;
            double f;
            Console.WriteLine("question 4:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input a Centigrade scale:");
                str = Console.ReadLine();
                c = Convert.ToDouble(str);
                f = 1.8 * c + 32;
                Console.WriteLine("Fahrenheit:{0:#0.#}", f);
            }
        }
        public void q5()
        {
            int i;
            string str;
            double x;
            double y;
            Console.WriteLine("question 5:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input a x:");
                str = Console.ReadLine();
                x = Convert.ToDouble(str);
                y = (5 * x * x) - (4 * x) + 3;
                Console.WriteLine("y:{0}", y);
            }

        }
        public void q6()
        {
            int i;
            string str;
            double x1;
            double x2;
            double y1;
            double y2;
            double s;
            Console.WriteLine("question 6:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input a x1:");
                str = Console.ReadLine();
                x1 = Convert.ToDouble(str);

                Console.Write("input a y1:");
                str = Console.ReadLine();
                y1 = Convert.ToDouble(str);

                Console.Write("input a x2:");
                str = Console.ReadLine();
                x2 = Convert.ToDouble(str);

                Console.Write("input a y2:");
                str = Console.ReadLine();
                y2 = Convert.ToDouble(str);

                s = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                Console.WriteLine("Distance:{0}", s);
            }

        }
        public void q7()
        {
            int i;
            string str;
            double s;
            Console.WriteLine("question 7:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input distance:");
                str = Console.ReadLine();
                s = Convert.ToDouble(str);
                s = 2.4 + s * 0.4;
                Console.WriteLine("fare:{0}", s);
            }
        }
        public void q8()
        {

            int i;
            string str;
            double s;
            Console.WriteLine("question 8:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input distance:");
                str = Console.ReadLine();
                s = Convert.ToDouble(str);
                s = 2.4 + s * 0.4;
                s = Math.Round(s,1);
                Console.WriteLine("fare:{0}", s);
            }
        }
        public void q9()
        {

            int i;
            string str;
            double s;
            Console.WriteLine("question 9:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input distance:");
                str = Console.ReadLine();
                s = Convert.ToDouble(str);
                s = 2.4 + s * 0.4;
                s = s * 10;
                s = Math.Ceiling(s);
                s = s / 10;
                Console.WriteLine("fare:{0}", s);
            }
        }
        public void q10()
        {
            int i;
            string str;
            double a;
            double b;
            double c;
            double s;
            double area;
            Console.WriteLine("question 10:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("input A:");
                str = Console.ReadLine();
                a = Convert.ToDouble(str);

                Console.Write("input B:");
                str = Console.ReadLine();
                b = Convert.ToDouble(str);

                Console.Write("input C:");
                str = Console.ReadLine();
                c = Convert.ToDouble(str);

                if ((a+b)<c||(a+c)<b||(b+c)<a) {
                    Console.WriteLine("wrong triangle");
                }
                else
                {
                    s = (a + b + c) / 2;
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    Console.WriteLine("Area:{0}",area);

                }
                
            }

        }
    }
}

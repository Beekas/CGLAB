using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2CG
{
    class Program
    {

        class Point
        {
            public int x, y;
            public Point()
            {
                x = 0;
                y = 0;
            }
        }

        class Line
        {
            public Point Point1 = new Point();
            public Point Point2 = new Point();

        }
        static void Main(string[] args)
        {
            try
            {

                Point Point3 = new Point();
                Line Line1 = new Line();
                string P1 = "", P2 = "", P3 = "";
                getData();
                checkturntest(AreaofTriangle(Line1.Point1, Line1.Point2, Point3));
                Console.ReadKey();
                void getData()
                {

                    Console.WriteLine("Enter origin point");
                    P1 = Console.ReadLine();

                    Console.WriteLine("Enter refrence point.");
                    P2 = Console.ReadLine();

                    Console.WriteLine("Enter Point to test.");
                    P3 = Console.ReadLine();

                    Line1.Point1.x = int.Parse(P1.Split(',')[0]);
                    Line1.Point1.y = int.Parse(P1.Split(',')[1]);

                    Line1.Point2.x = int.Parse(P2.Split(',')[0]);
                    Line1.Point2.y = int.Parse(P2.Split(',')[1]);


                    Point3.x = int.Parse(P3.Split(',')[0]);
                    Point3.y = int.Parse(P3.Split(',')[1]);
                }


                // 1/2 (xayb-xayc+xbyc-xbya+xcya-xcyb)
                double AreaofTriangle(Point a, Point b, Point c)
                {
                    double area = (a.x * b.y - a.x * c.y + b.x * c.y - b.x * a.y + c.x * a.y - c.x * b.y) * .5;
                    return area;
                }

                void checkturntest (double area)
                {
                    if (area > 0)
                    {
                        Console.WriteLine("left turn");
                    }
                    else if (area < 0)
                    {
                        Console.WriteLine("right turn");
                    }
                    else if (area == 0)
                    {
                        Console.WriteLine("Collinear");
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }



        }
    }
}

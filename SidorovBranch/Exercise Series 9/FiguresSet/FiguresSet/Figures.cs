using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    class Figures
    {
        private static readonly Random rnd = new Random();

        private const int MAX_DIMENSION = 10;
        /// <summary>
        /// Creates "count" rectangles and adds to "rects" list
        /// </summary>
        /// <param name="rects">list of rectangles to add to</param>
        /// <param name="count">how many rectangles will be created</param>
        static void CreateSomeRectangles(IPut<Rectangle> rects, int count)
        {
            for (int index = 0; index < count; index++)
            {
                rects.Add(new Rectangle(
                    rnd.NextDouble() * rnd.Next(MAX_DIMENSION), 
                    rnd.NextDouble() * rnd.Next(MAX_DIMENSION)));
            }
        }
        /// <summary>
        /// Creates "count" circles and adds to "circles" list
        /// </summary>
        /// <param name="rects">list of circles to add to</param>
        /// <param name="count">how many circles will be created</param>
        static void CreateSomeCircles(IPut<Circle> circles, int count)
        {
            for (int index = 0; index < count; index++)
            {
                circles.Add(new Circle(
                    rnd.NextDouble() * rnd.Next(MAX_DIMENSION)));
            }
        }
        /// <summary>
        /// Calculate total square of all figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>total square</returns>
        static double CalculateSquare(IGet<Figure> figures)
        {
            double ret = 0.0;
            for (int index = 0; index < figures.Length; index++)
            {
                ret += figures.Get(index).GetSquare();
            }
            return ret;
        }

        /// <summary>
        /// Printing types and squares of figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        static void Print(IGet<Figure> figures)
        {
            for (int index = 0; index < figures.Length; index++)
            {
                Figure f = figures.Get(index);
                Console.WriteLine("Name: {0}, square: {1}", f.GetType().Name, f.GetSquare());
            }
        }

        /// <summary>
        /// Main figures method
        /// </summary>
        public static void VarianceJob()
        {
            // generic variance (covariance and contravariance)

            /*1) создать коллекцию фигур
             * 2) добавить 10 кружочков (с помощью метода AddSomeCircles, принимающего 
             * ссылку на коллекцию кружочков)
             * 3) добавить 5 прямоугольников
             * (с помощью метода AddSomeRectangles, принимающего ссылку на коллекцию прямоугольников)
             * 4) добавить 5 кружочков (с помощью метода AddSomeCircles, принимающего ссылку на коллекцию 
             * кружочков)
             * 5) посчитать сумму площади для всех фигур (использовать метод CalculateSquare, передавая 
             * туда всю коллекцию фигур)*/
            MyList<Figure> figures = new MyList<Figure>();
            CreateSomeCircles(figures, 10);                         // that's generic contravariance
            CreateSomeRectangles(figures, 5);                      // that's generic contravariance
            CreateSomeCircles(figures, 5);                         // that's generic contravariance
            Print(figures);
            Console.WriteLine("Total square: {0}", CalculateSquare(figures));
            

            /* 6) создать коллекцию кружочков, добавить туда 20 кружочков
             * 7) создать коллекцию прямоугольников, заполнить 10-ю прямоугольниками
             * 8) Посчитать общую площадь для (6) и (7)
             * 9) вывести список типов элементов коллекции (hint: используйте GetType())*/
             
            MyList<Circle> circles2 = new MyList<Circle>();
            CreateSomeCircles(circles2, 20);
            //Print(circles);                                                   // that's generic covariance
           // Console.WriteLine("Total square: {0}", CalculateSquare(circles)); // that's generic covariance
            
            MyList<Rectangle> rectangles2 = new MyList<Rectangle>();
            CreateSomeRectangles(rectangles2, 10);
           // Print(rectangles);                                                   // that's generic covariance
            //Console.WriteLine("Total square: {0}", CalculateSquare(rectangles)); // that's generic covariance

            MyList<Figure> figures2 = new MyList<Figure>();
            figures2.AddRange(circles2);
            figures2.AddRange(rectangles2);
            Print(figures2);                                                   // that's generic covariance
            Console.WriteLine("Total square: {0}", CalculateSquare(figures2)); // that's generic covariance

        }
    }
}

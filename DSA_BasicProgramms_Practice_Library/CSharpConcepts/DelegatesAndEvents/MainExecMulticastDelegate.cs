using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate void RectangleDelegate(double width, double height);
    public class MainExecMulticastDelegate
    {
        public static void ExecMulticastDelegate()
        {
            Rectangle rect = new Rectangle();
            RectangleDelegate rectangleDelegate = new RectangleDelegate(rect.GetArea);
            rectangleDelegate += rect.GetPerimeter;

            Delegate[] invocationList = rectangleDelegate.GetInvocationList();
            Console.WriteLine("Invocation List");

            foreach (var item in invocationList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Invocation multicast delegate.");
            rectangleDelegate(23.45, 67.89);

            Console.WriteLine();
            Console.WriteLine("Invoking multicast Delegate after removing one pipeline.");

            rectangleDelegate -= rect.GetPerimeter;
            rectangleDelegate.Invoke(13.45, 76.89);

        }
    }

    public class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine($"Area is {width * height}");
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter is {2 * (width + height)}");
        }
    }
}

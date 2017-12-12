using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTask
{
    public class Questions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the Fruit Shop.");
            List<Apple> apples = new List<Apple>();
            Apple apple = new Apple();
            apples.Add(apple);
            apples.Add(apple);
            apples.Add(apple);
            apples.Add(apple);
            apples.Add(apple);

            List<Apple> redapples = new List<Apple>();
            Apple redapple = new Apple();
            redapples.Add(redapple);
            redapples.Add(redapple);
            redapples.Add(redapple);
            redapples.Add(redapple);
            redapples.Add(redapple);
            redapples.Add(redapple);
            redapples.Add(redapple);

            Console.WriteLine($"\n We Currently Have : {apples.Count().ToString()} Apples and {redapples.Count().ToString()} Red Apples Available");

            Box<Apple> box = new Box<Apple>();
            box.Add(apples);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\n In our 1st Box we have:\n\n {box.Count().ToString()} Apples");
            Console.ReadLine();
            Console.ResetColor();

            Box<Apple> box2 = new Box<Apple>();
            box2.Add(redapples);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\n In our 2nd Box we have:\n\n {box2.Count().ToString()} Red Apples");
            Console.ReadLine();
            Console.ResetColor();

            Cart<Apple> CartAppleContents = new Cart<Apple>();
            CartAppleContents.boxes.Add(box);
            CartAppleContents.boxes.Add(box2);
            Console.WriteLine($"\n\n We have {CartAppleContents.boxes.Count()} boxes and {CartAppleContents.Count().ToString()} Apples in the cart.");
            Console.ReadLine();

        }
    }
}
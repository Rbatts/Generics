using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericsTask.Apple;

namespace GenericsTask
{
    public class Questions
    {
        public static int GreenAppleCounter = 0;
        public static int RedAppleCounter = 0;

        delegate int CountGreenApples(int count);
        delegate int CountRedApples(int count);

        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the Fruit Shop.");
            Apple apple = new Apple();

            List<Apple> myApple = new List<Apple>()
            {
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple {Colour = AppleColour.RedApple},
                new Apple {Colour = AppleColour.RedApple},
                new Apple {Colour = AppleColour.RedApple}
            };

            Console.WriteLine($"\n We Currently Have : {myApple.Count} Apples in Stock");
            Console.ReadLine();

            CountRedApples redValue = RedCounterMethod;
            CountGreenApples greenValue = GreenCounterMethod;
            greenValue(GreenAppleCounter);
            redValue(RedAppleCounter);
            Console.ReadLine();

            Box<Apple> box = new Box<Apple>();
            box.Add(myApple);
            Console.WriteLine($"\n I Can Sell You A Box Of : \n\n {box.Count()} Apples");
            Console.ReadLine();

            //Box<Apple> box2 = new Box<Apple>();
            //box2.Add(myApple);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"\n In our 2nd Box we have:\n\n {box2.Count()} Red Apples");
            //Console.ReadLine();
            //Console.ResetColor();

            Cart<Apple> CartAppleContents = new Cart<Apple>();
            CartAppleContents.boxes.Add(box);
            //CartAppleContents.boxes.Add(box2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n We have {CartAppleContents.boxes.Count} box[es] and {CartAppleContents.Count()} Apples in the cart.");
            Console.ResetColor();
            Console.ReadLine();

            int RedCounterMethod(int RedAppleCounter)
            {
                foreach (Apple singleRedApple in myApple)
                {
                    if (singleRedApple.Colour == AppleColour.RedApple)
                    {
                        RedAppleCounter++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n {RedAppleCounter} Red Apples");
                Console.ResetColor();
                return RedAppleCounter;
            }

            int GreenCounterMethod(int GreenAppleCounter)
            {
                foreach (Apple singleGreenApple in myApple)
                {
                    if (singleGreenApple.Colour == AppleColour.GreenApple)
                    {
                        GreenAppleCounter++;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n {GreenAppleCounter} Green Apples");
                Console.ResetColor();
                return GreenAppleCounter;
            }
        }
    }
}
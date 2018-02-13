using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static GenericsTask.Apple;
using System.Linq;

namespace GenericsTask
{
    public class Questions
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the Fruit Shop. We Currently Have ");

            List<Apple> appleCollection = new List<Apple>()
            {
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.GreenApple},
                new Apple{Colour = AppleColour.RedApple},
                new Apple{Colour = AppleColour.RedApple},
                new Apple{Colour = AppleColour.RedApple}
            };

            Func<Apple, bool> isRedApple = (individualApple) => individualApple.Colour == AppleColour.RedApple;
            var redAppleCount = appleCollection.Count(isRedApple);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n {redAppleCount} Red Apples");
            Console.ReadLine();
            Console.ResetColor();

            Func<Apple, bool> isApple = (individualApple) => true;
            var AppleCount = appleCollection.Count(isApple);
            Console.WriteLine($" {AppleCount} Apples Total");
            Console.ReadLine();

            Box<Apple> box = new Box<Apple>();
            box.Add(appleCollection);
            Console.WriteLine($" I Can Sell You A Box Of : {box.Count()} Apples");
            Console.ReadLine();

            Cart<Apple> cartAppleContents = new Cart<Apple>();
            cartAppleContents.Boxes.Add(box);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" In My Cart I Have {cartAppleContents.Boxes.Count} box[es] and {cartAppleContents.Count()} Apples in the Box.");
            Console.ResetColor();
            Console.ReadLine();
        }

    }
}
using System;

namespace StarWars.Resistance
{
    public class Program
    {
        public static void Main()
        {
            var array = new[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            var maxCanonsR2D2 = Solution1.Solution(array);
            var maxCanonsC3PO = Solution2.Solution(array);
            var maxCanonsBB8 = Solution3.Solution(array);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("                           STAR WARS");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   Coded by patocl@gmail.com");
            Console.WriteLine("                        A NEW CHALLENGE");
            Console.WriteLine();
            Console.WriteLine($"A long time ago in a galaxy far, far away...");
            Console.WriteLine("You are  part of  the  Resistance in the Star Wars universe...");
            Console.WriteLine("You are in an old  rebel base on the  planet Craig. The forces");
            Console.WriteLine("of the First Order will land their troops on the planet in the");
            Console.WriteLine("next few hours....");
            Console.WriteLine();
            Console.WriteLine("You must program an algorithm so that the only functional drone");
            Console.WriteLine("available to the alliance can load the correct number  of laser");
            Console.WriteLine("cannons into  the base and  deploy  them to nearby  peaks, in a");
            Console.WriteLine("single flight.");
            Console.WriteLine();
            Console.WriteLine("At the base, the radar scans the  surface and  provides us with");
            Console.WriteLine("information on the heights of nearby mountains.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Our droids provide the following instructions to  the Drone, for");
            Console.WriteLine("following coordinates:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"   {{ {string.Join(", ", array) } }}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"R2D2: bleep bloop beep beep {maxCanonsR2D2}");
            Console.WriteLine($"C3PO: I suggest a new strategy, R2: {maxCanonsC3PO}");
            Console.WriteLine($"BB8: beep-boop-beep {maxCanonsBB8}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("They got the same result, using 3 different algorithms,  please");
            Console.WriteLine("review the Readme.md file to the whole history!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}

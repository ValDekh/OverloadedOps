using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Point ptFour = new Point(1, 1);
            Point ptFive = new Point(20, 20);
            Console.WriteLine($"ptOne + ptTwo: {ptOne + ptTwo}");
            Console.WriteLine($"ptOne - ptTwo: {ptOne - ptTwo}");
            Point ptThree = new Point(120, 120);
            Console.WriteLine($"ptThree + 10: {ptThree + 10} ");
            Console.WriteLine($"ptThree -20: {ptThree - 20} ");

            Console.WriteLine("------------------------------");
            Console.WriteLine($"{ptOne += ptThree}");
            Console.WriteLine($"{ptThree -= 50}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"++ptFour = {++ptFour}");
            Console.WriteLine($"{ptFour}");
            Console.WriteLine($"--ptFour = {--ptFour}");
            Console.WriteLine($"{ptFour}");
            
            Console.WriteLine("------------------------------");
            Console.WriteLine($"ptFour++ = {ptFive++}");
            Console.WriteLine($"{ptFive}");
            Console.WriteLine($"ptFive-- = {ptFive--}");
            Console.WriteLine($"{ptFive}");
            Console.WriteLine("________________________________");
            Console.WriteLine($"ptOne == ptTwo : {ptOne == ptTwo}");
            Console.WriteLine($"ptOne != ptTwo : {ptOne != ptTwo} ");
            Console.WriteLine("________________________________");
            Console.WriteLine("ptOne < ptTwo : {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne > ptTwo : {0}", ptOne > ptTwo);
        }
    }
}
using System;

namespace MethodExersise
{
    class MethodExersise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXAMPLE A OF THE METHODS");
            WriteStuff();
            WriteSomethingSpecific("This is a method with ConsoleWrite function see it?");
            //WriteSomethingSpecific("");

            Console.WriteLine("EXAMPLE B OF THE METHODS ADDING NUMMBERS");
            Console.WriteLine(Add(Add(2, 2), Add(3, 4)));

            Console.WriteLine("EXAMPLE C of ADDTION METHOD");
            Console.WriteLine(Multiply(65, 25));


            Console.WriteLine("EXAMPLE D of DIVIDE METHOD");
            Console.WriteLine(Devide(60, 30));
            //Add(Add(1, 2) Add(3,4));
        }

        // IMPORTANT THE ACSSES MODIFIER STATIC REUTRN TYPE METHOD name(parameter 1 parameter 2)
        public static void WriteStuff()
        {
            Console.WriteLine("This is a method if you see me it means I've been summened");
        }

        public static void WriteSomethingSpecific(string mytext)
        {
            Console.WriteLine(mytext);
        }




        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Devide(double num1, double num2)// IF YOU DIVDE INT WITH DOULBE THEY CUT OFF THE NUMMBER
        {
            return num1 / num2;
        }

    }
}

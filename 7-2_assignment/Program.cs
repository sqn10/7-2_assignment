namespace _7_2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment1();

            //Console.WriteLine();
            //Console.WriteLine();

            //Assignment2();

            //Console.WriteLine();
            //Console.WriteLine();

            Assignment3();
        }
        public static void Assignment1()
        {
           Console.WriteLine("BLAST OFF!!!");

           Console.WriteLine("T minus");
            for (int i = 10; i >= 0; i -= 1)
            {
                Console.WriteLine(i);
                new Thread(() => Beep700ms()).Start();
                Thread.Sleep(1000);
            }

            Console.WriteLine("BLAST OFF!!!!!");
            new Thread(() => Song()).Start();
        }
        public static void Assignment2()
        {
            int y = 0;
            Console.WriteLine("\t X" + "\t Y");

            for (int x = -10; x <= 10; x = x + 2)
            {
                y = x * x;
                Console.WriteLine("\t" + x + "\t" + y);
            }
        }
        public static void Assignment3()
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (input != "aldworth".ToLower())
                {
                    Console.WriteLine(i + ". " + input);
                }
            }
        }
        public static void Song()
        {
            // note: i don't think the computer's speaker in class can play low enough for this.
            for (int freq = 700; freq >= 350; freq -= 10) 
            {
                Console.Beep(freq, 125);
            }
        }
        public static void Beep700ms()
        {
            Console.Beep(700, 1000);
        }
    }
}

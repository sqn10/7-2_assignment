namespace _7_2_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1();

            Console.WriteLine();
            Console.WriteLine();

            Assignment2();

            Console.WriteLine();
            Console.WriteLine();

            Assignment3();
        }
        public static void Assignment1()
        {
            // BLAST OFF!!!

            Console.WriteLine("T minus");
            for (int i = 10; i >= 0; i -= 1)
            {
                Console.WriteLine(i);
                new Thread(() => Song2()).Start();
                Thread.Sleep(1000);
            }

            Console.WriteLine("BLAST OFF!!!!!");
            new Thread(() => Song()).Start();
        }
        public static void Assignment2()
        {

        }
        public static void Assignment3()
        {

        }
        public static void Song()
        {
            for (int freq = 700; freq >= 540; freq -= 20)
            {
                Console.Beep(freq, 20);
            }
        }
        public static void Song2()
        {
            Console.Beep(700, 1000);
        }
    }
}

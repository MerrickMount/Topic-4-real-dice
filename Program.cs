namespace Topic_4_real_dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Merrick
            int die1, die2;
            Random rnd = new Random();
            die1 = rnd.Next(1, 7);
            die2 = rnd.Next(1, 7);
            Console.WriteLine("This Program rolls 2 dice for you (Press Enter to continue)");
            Console.ReadLine();
            Console.WriteLine($"{die1},  {die2}");
            if (die1 == 1)
            {
                Console.WriteLine(" ____________\r\n|\t  \t|\r\n|\t  \t|\r\n|\t()\t|\r\n|\t  \t|\r\n| ___________ |\r\n");
            }
            if (die1 == 2)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()                 |\r\n|                        |\r\n|                 ()     |\r\n| ___________ |\r\n");
            }
            if (die1 == 3)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()                 |\r\n|           ()           |\r\n|                 ()     |\r\n| ___________ |\r\n");
            }
            if (die1 == 4)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|                        |\r\n|     ()         ()     |\r\n| ___________ |\r\n");
            }
            if (die1 == 5)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|           ()          |\r\n|     ()         ()     |\r\n| ___________ |\r\n");
            }
            if (die1 == 6)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|     ()         ()     |\r\n|     ()         ()     |\r\n| ___________ |\r\n");
            }

            if (die2 == 1)
            {
                Console.WriteLine(" ____________\r\n|\t  \t|\r\n|\t  \t|\r\n|\t()\t|\r\n|\t  \t|\r\n| ___________ |\r\n");
            }
            if (die2 == 2)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()                 |\r\n|                        |\r\n|                 ()     |\r\n| ___________ |\r\n") ;
            }
            if (die2 == 3)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()                 |\r\n|           ()           |\r\n|                 ()     |\r\n| ___________ |\r\n") ;
            }
            if (die2 == 4)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|                        |\r\n|     ()         ()     |\r\n| ___________ |\r\n") ;
            }
            if (die2 == 5)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|           ()          |\r\n|     ()         ()     |\r\n| ___________ |\r\n");
            }
            if (die2 == 6)
            {
                Console.WriteLine(" ____________\r\n|                        |\r\n|     ()         ()     |\r\n|     ()         ()     |\r\n|     ()         ()     |\r\n| ___________ |\r\n");
            }

        }
    }
}
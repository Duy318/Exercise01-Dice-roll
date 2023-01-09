using System;
using System.Text.RegularExpressions;
namespace Exercise01
{
    public class Dice
    {
        private int slides;
        public int roll()
        {
            Random random = new Random();
            int n = random.Next(1, 6);
            return n;
        }
    }
    public class Tester
    {
        static int checkNum()
        {
            String num;
            num = Console.ReadLine();
            while (Regex.IsMatch(num, "\\d") == false)
            {
                Console.Write("Enter your number: ");
                num = Console.ReadLine();
            }
            return Convert.ToInt32(num);
        }

        public static void Main(String[] args)
        {
            Console.Write("Enter your number: "); int n = checkNum();
            Console.WriteLine("Waitting for roll the dice......");
            int num = new Dice().roll();
            Console.Write("The number of buttons for this roll of the dice: " + num + "\n");
            if (n == num)
                Console.WriteLine("Congratulations! You guessed correctly!");
            else { Console.WriteLine("Wish you luck next time"); }
            Console.ReadLine();
        }
    }
}

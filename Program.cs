/*File Name: HomeworkWeek5part2
 * Programmer: Nasi Bode
 * Probolem Statement: write a program that will print out statistics for each coin tosses.
 * The user will input either an "h" for heads or a "t" for tails for the eight tosses. The 
 * program will then print out the total number and percentages of heads and tails. Use the
 * increment operator to increment the number of tosses as each toss is input. 
 * Overall Plan: 
 * 1. Print welcoming message to screen
 * 2. Prompt user to enter h or t (heads, tails) for coin toss
 * 3. Create a counter for amount of time coin was tossed
 * 4. Create a counter for amount of heads
 * 5. Create a counter for amount of tails
 * 6. Convert user input to char
 * 7. For each user input, if char equals h add to heads counter
 * 8. Fore each user input, if char equals t add to tails counter
 * 9. Calculate percentage of heads out of the total
 * 10.Calculate percentage of tails out of the total
 * 11.Output the results to the screen (format percentage to two decimals)
 *
*/


using System;

namespace HomeworkWeek5Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print welcoming message to the screen
            Console.WriteLine("Hello! This program will print out statistics for eight coin tosses");
            //give user instructions
            Console.WriteLine("\nEnter 'h' or 't', for heads or tails when prompted");
            //create variable to keep track of how many times coin was flipped
            int timeFlipped = 1;
            //create variables for coin heads to keep track of how many of each
            int heads = 0;
            int tails = 0;
            //create while loop to continue while coin heads are flipped
            while (timeFlipped <= 8)
            {
                //get user input for first coin toss
                Console.WriteLine("\nFirst Toss: ");
                char first = Convert.ToChar(Console.ReadLine());
                //add count to the correct coin head
                if (first == 'h')
                {
                    heads += 1;
                }
                if (first == 't')
                {
                    tails += 1;
                }
                //add 1 to the amount of times coin was tossed
                timeFlipped += 1;
                //repeat for the eight coin tosses
                Console.WriteLine("\nSecond Toss: ");
                char second = Convert.ToChar(Console.ReadLine());
                if (second == 'h')
                {
                    heads += 1;
                }
                if (second == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nThird Toss: ");
                char third = Convert.ToChar(Console.ReadLine());
                if (third == 'h')
                {
                    heads += 1;
                }
                if (third == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nFourth Toss: ");
                char fourth = Convert.ToChar(Console.ReadLine());
                if (fourth == 'h')
                {
                    heads += 1;
                }
                if (fourth == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nFifth Toss: ");
                char fifth = Convert.ToChar(Console.ReadLine());
                if (fifth == 'h')
                {
                    heads += 1;
                }
                if (fifth == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nSixth Toss: ");
                char sixth = Convert.ToChar(Console.ReadLine());
                if (sixth == 'h')
                {
                    heads += 1;
                }
                if (sixth == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nSeventh Toss: ");
                char seventh = Convert.ToChar(Console.ReadLine());
                if (seventh == 'h')
                {
                    heads += 1;
                }
                if (seventh == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                Console.WriteLine("\nEighth Toss: ");
                char eigth = Convert.ToChar(Console.ReadLine());
                if (eigth == 'h')
                {
                    heads += 1;
                }
                if (eigth == 't')
                {
                    tails += 1;
                }
                timeFlipped += 1;

                //find the percentage of the coin tosses
                double percentHeads = ((double)heads / 8) * 100;
                double percentTails = ((double)tails / 8) * 100;

                //output the result of the coin toss
                Console.WriteLine("\nTotal head count: {0}", heads);
                Console.WriteLine("\nTotal tails count: {0}", tails);
                Console.WriteLine("\nPercent heads: {0:0.00}%", percentHeads);
                Console.WriteLine("\nPercent Tails: {0:0.00}%", percentTails);



            } 
            

        }
    }
}

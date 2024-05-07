using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COWS AND BULLS");
            Console.WriteLine(" ");
            Console.WriteLine("Do you know how to play this game");
            string anws = Console.ReadLine();
            if (anws == "no" || anws == "No" || anws == "Nah" || anws == "nah" || anws == "nO")
            {
                Console.WriteLine("Cows and Bulls is a game where a player tries to guess a four digit number with no repeating digits. The number can also not start with 0 ");
                Console.WriteLine("When the user guesses the number they should be given feedback on their guess.");

                Console.WriteLine("If they have the number correct they win ");

                Console.WriteLine("If they haven't then they are told how many 'Cows' and how many 'Bulls' they have ");

                Console.WriteLine("A Cow means they have one of the digits in the number but not in the correct position ");

                Console.WriteLine("A Bull means they have one of the digits in the number in the correct position If the number guessed is invalid they should be told 'Not a valid guess' and not told how many cows and bulls there are");
            }

            Random random = new Random();
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] number = new int[4];

            number[0] = digits[random.Next(1, 9)]; // Ensure the first digit is not zero
            while (number[0] == number[1] || number[0] == number[2] || number[0] == number[3] || number[1] == number[2] || number[1] == number[3] || number[2] == number[3])
            {
                for (int i = 1; i < 4; i++)
                {
                    int index = random.Next(0, 10 - i);
                    number[i] = digits[index];
                    digits[index] = digits[9 - i];
                }
            }

            int result = number[0] * 1000 + number[1] * 100 + number[2] * 10 + number[3];




            ///Next Bit
            bool x = false;
            while (x == false)
            {
                Console.WriteLine("Please enter a 4-digit number:");
                string input = Console.ReadLine();

                if (input.Length != 4)
                {
                    Console.WriteLine("Invalid input. Please enter a 4-digit number.");

                }
                else
                {


                    if (input[0] == '0')
                    {
                        Console.WriteLine("The number should not start with 0.");
                    }
                    else
                    {

                        if (input[0] == input[1] || input[0] == input[2] || input[0] == input[3] || input[1] == input[2] || input[1] == input[3] || input[2] == input[3])
                        {
                            Console.WriteLine("The number should not have repeating digits.");
                        }
                        else
                        {

                            Console.WriteLine("The number is valid.");
                            x = true;
                        }
                    }
                }
                int inputactual = Convert.ToInt32(input);
                int cows = 0;
                int bulls = 0;
                int num = 0;
                Console.WriteLine("How many turns do you want");
                int numofturns = Convert.ToInt32(Console.ReadLine());
                while (inputactual != result || num != numofturns)
                {
                    string result2 = Convert.ToString(result);
                    string input2 = input;
                    for (int i = 0; i < 4; i++)
                        if (result2[i] == input2[i])
                        {
                            bulls = bulls + 1;
                        }
                    for (int i = 0; i < 4; i++)

                        if (input2[i] == result2[0])
                        {
                            cows = cows + 1;
                        }
                    for (int i = 0; i < 4; i++)
                        if (input2[i] == result2[1])
                        {
                            cows = cows + 1;
                        }

                    for (int i = 0; i < 4; i++)
                        if (input2[i] == result2[2])
                        {
                            cows = cows + 1;
                        }
                    for (int i = 0; i < 4; i++)
                        if (input2[i] == result2[3])
                        {
                            cows = cows + 1;
                        }
                    Console.WriteLine("You have " + cows + " cows and " + bulls + " bulls");
                    x = false;
                    while (x == false)
                    {
                        Console.WriteLine("Please enter a 4-digit number:");
                        input = Console.ReadLine();

                        if (input.Length != 4)
                        {
                            Console.WriteLine("Invalid input. Please enter a 4-digit number.");

                        }
                        else
                        {


                            if (input[0] == '0')
                            {
                                Console.WriteLine("The number should not start with 0.");
                            }
                            else
                            {

                                if (input[0] == input[1] || input[0] == input[2] || input[0] == input[3] || input[1] == input[2] || input[1] == input[3] || input[2] == input[3])
                                {
                                    Console.WriteLine("The number should not have repeating digits.");
                                }
                                else
                                {

                                    Console.WriteLine("The number is valid.");
                                    x = true;
                                }
                            }
                        }
                        inputactual = Convert.ToInt32(input);
                        cows = 0;
                        bulls = 0;
                        num = num + 1;
                    }
                }
            }

        }
    }
}

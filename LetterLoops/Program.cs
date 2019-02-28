using System;
using System.Collections.Generic;
using System.Text;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string of letters.");
            var userInput = Console.ReadLine();
            var userOutput = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        userOutput += userInput[i].ToString().ToUpper();
                    }
                    else
                    {
                        userOutput += userInput[i].ToString().ToLower();
                    }
                }
                if (userInput[i] != userInput.Length - 1)
                {
                    userOutput += "-";
                }
        }
            Console.WriteLine(userOutput);
            Console.ReadKey();
        }
    }
}

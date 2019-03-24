using System;

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
                if (i != userInput.Length - 1)
                {
                    userOutput += "-";
                }
            }
            Console.WriteLine(userOutput);
            Console.ReadKey();
        }
    }
}

//Nathan's Solution
//Console.WriteLine("Please enter a string of letters.");
//var userInput = Console.ReadLine().ToLower();
//var loopCount = 0;
//var myCharacters = new List<string>();

//foreach (var character in userInput)
//    {
//    var letterString = character.ToString().ToUpper();
//    letterString += new string(character, loopCount);

//    myCharacters.Add(letterString);

//    loopCount++;
//    }
//    Console.Write(string.Join('-', myCharacters));

 

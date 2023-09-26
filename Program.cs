using System;
using System.Collections.Generic;

namespace Lesson_15___Random_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int task1 = Random1to10();
            Console.WriteLine($"This is task 1: {task1}");

            //---------- TASK 2 ---------
            Console.WriteLine();
            Console.WriteLine($"This is task 2: {RandomBoolean()}");
            //---------- TASK 3 ---------
            Console.WriteLine();
            Console.WriteLine($"Random Letter: {RandomLetter()}");
            Console.WriteLine($"Random Password: {passwordGenerator_ABC()}");
            Console.WriteLine();

            //---------- TASK 4 ---------
            #region TASK4: (1+6)x100


            //Console.WriteLine();
            //int sum = 0;


            //for (int i = 1; i < 101; i++)
            //{
            //    int pirmas = Random1to6();
            //    int antras = Random1to6();
            //    sum = pirmas + antras;
            //    Console.WriteLine($" Case {i} : {pirmas}+{antras} = {sum}");
            //    sum = 0;
            //}

            #endregion

            #region Task5 Guess number


            //int task5 = Random1to100();

            ////int userGuess = Convert.ToInt32(Console.ReadLine());

            //int userNumber;
            //do
            //{
            //    Console.WriteLine("Input a number");
            //    string userGuess = Console.ReadLine();
            //    bool task5Dalykas = int.TryParse(userGuess, out userNumber);

            //    if (task5Dalykas == true)
            //    {

            //        if (userNumber > task5)
            //        {
            //            Console.WriteLine("Go lower:");
            //        }
            //        else if (userNumber < task5)
            //        {
            //            Console.WriteLine("Go higher:");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("That wasn't a number:");
            //    }
            //}
            //while (userNumber != task5);
            //Console.WriteLine($"Congrats! The number is {task5}");

            #endregion

            #region Task6
            Console.WriteLine("========== TASK 6 ==========");
            int rows = Random1to8();
            int cols = Random1to8();
            int[,] matrix = new int[rows, cols];

            //POPULATE THE MATRIX

            Random astuom = new Random();
            int betkas = astuom.Next(1, 81);

            #region TooDifficultandFaultyThinkings
            //List<int> listRows = new List<int>();
            //List<int> listCols = new List<int>();

            //-- 
            //for (int i = 0; i < rows; i++)
            //{
            //    betkas = astuom.Next(1, 81);
            //    listRows.Add(betkas);

            //    for (int j = 0; j < cols; j++)
            //    {
            //        betkas = astuom.Next(1, 81);
            //        listCols.Add(betkas);
            //    }
            //    cols = listCols.ToArray();
            //}
            //rows = listRows.ToArray();
            #endregion

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = astuom.Next(1, 81); // Populate matrix with random values between 1 and 80
                }
            }


            // DISPLAY THE MATRIX
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");//keisti
                }
                Console.WriteLine();
            }



            #endregion
        }
        //-------------------------------------- METHODS -----------------------------------------
        public static char RandomLetter()
        {
            string englishABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//string
            int ABClength = englishABC.Length;//length
            //Console.WriteLine($"Size of the ABC is {ABClength}");
            char[] englishAlphabet = englishABC.ToCharArray();//char array

            Random randSkaicius = new Random();//create random
            int letter_ABCposition = randSkaicius.Next(0, ABClength);//create specific random number in constraints of ABC

            return englishAlphabet[letter_ABCposition];//write one random letter //"char randomChar = "
        }

        public static string passwordGenerator_ABC()
        {
            string englishABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//string
            int ABClength = englishABC.Length;//length
            //Console.WriteLine($"Size of the ABC is {ABClength}");
            char[] englishAlphabet = englishABC.ToCharArray();//char array

            Random randSkaicius = new Random();//create random
            int letter_ABCposition = randSkaicius.Next(0, ABClength);//create specific random number in constraints of ABC

            char randomChar = englishAlphabet[letter_ABCposition];//write one random letter
            //Console.WriteLine(randomChar);

            //passwordGenerator_ABC
            int passwordLength = 8;
            List<char> passwordMethod = new List<char>();


            for (int i = 0; i < passwordLength; i++)
            {
                letter_ABCposition = randSkaicius.Next(0, ABClength);
                randomChar = englishAlphabet[letter_ABCposition];
                passwordMethod.Add(randomChar);

            }
            //string passwordComplete = Convert.ToString(passwordMethod.ToArray());//convert neveikia su masyvais
            string passwordComplete = new string(passwordMethod.ToArray()); // convert list to string
            //new kazkas kai konvertinam is masyvo i string
            return passwordComplete;
        }

        public static bool RandomBoolean()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 3);


            if (metodoSkaicius == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region RandomRanges
        public static int Random1to6()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 7);
            return metodoSkaicius;
        }
        public static int Random1to8()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 9);
            return metodoSkaicius;
        }

        public static int Random1to10()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 11);
            return metodoSkaicius;
        }

        public static int Random1to80()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 81);
            return metodoSkaicius;
        }
        public static int Random1to100()
        {
            Random randSkaicius = new Random();
            int metodoSkaicius = randSkaicius.Next(1, 101);
            return metodoSkaicius;
        }
        #endregion



        // ------ end of methods -------
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoopsGame
{
    class GameArcade
    {

        public string NameInput { get; set; }
        public List <int> MaxAndMinUserInput { get; set; }
        public int NumberInput { get; set; }
        public List<int> RandomBinaryPin { get; set; }
        public List<int> UserGuessedPin { get; set; }




        public void CheckForAs()
        {
            char checkForCapitalA = 'A';
            char checkForLowerA = 'a';
            int numberOfAs = 0;

            for (int i = 0; i < NameInput.Length; i++)
            {
                if (NameInput[i] == checkForCapitalA || NameInput[i] == checkForLowerA)
                {
                    numberOfAs++;
                }
            }

            Console.WriteLine($"{NameInput} has {numberOfAs} letter 'a's!");
        }
       
        public void CheckForMaxAndMin()
        {
            int maximumValue = MaxAndMinUserInput[0];
            int minimumValue = MaxAndMinUserInput[0];

            for (int i= 0; i < MaxAndMinUserInput.Count; i++)
            {
                if (MaxAndMinUserInput[i] > maximumValue)
                {
                    maximumValue = MaxAndMinUserInput[i];
                }

                if (MaxAndMinUserInput[i] < minimumValue)
                {
                    minimumValue = MaxAndMinUserInput[i];
                }
                   
            }

            Console.WriteLine($"The maxiumum value is {maximumValue} and the minimum value is {minimumValue} ");
        }   
           

        public void CountByOdds()
        {
            int loopCount = 0;
            for(int countTo = 1; countTo <= NumberInput; countTo +=2)
            {
                Console.WriteLine(countTo);
                loopCount++;

            }
            Console.WriteLine($"Counted {loopCount} odd numbers!");
        }

        public void CreateRandomPin()
        {
            var tempList = new List<int>();

            Random random = new Random();
            int firstDigit = random.Next(0, 2);
            int secondDigit = random.Next(0, 2);
            int thirdDigit = random.Next(0, 2);

            tempList.Add(firstDigit);
            tempList.Add(secondDigit);
            tempList.Add(thirdDigit);

            RandomBinaryPin = tempList;
            Console.WriteLine(RandomBinaryPin[0]);
            Console.WriteLine(RandomBinaryPin[1]);
            Console.WriteLine(RandomBinaryPin[2]);
        }

        public void CheckIfPinMatches()
        {
            int perfectMatches = 0;

            for(int i = 0; i < 3; i++)
            {
                if (UserGuessedPin[i] == RandomBinaryPin[i])
                {
                    perfectMatches ++;
                }               
               
            }
            if (perfectMatches == 3)
            {
                Console.WriteLine("Congratulations, you have guessed the Binary PIN!");
            }
            else
            {
                Console.WriteLine("Incorrect, try again!");
            }

        }

    }


}


using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRollAssignment
{
    public class GuessingEngine
    {
        private int _triesLeft = 3;
        private readonly Die _dice;
        public GuessingEngine(Die die)
        {
            _dice = die;
        }

        public void Play()
        {
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            while (_triesLeft > 0)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Oops! Incorrect input.");
                    continue;
                }
                if (guess == _dice.Value)
                {
                    Console.WriteLine("You win!");
                    return;
                }
                else
                {
                    Console.WriteLine("Oops! Wrong number.");
                    _triesLeft--;
                }
            }
            Console.WriteLine("You lose! The correct number was " + _dice.Value);
        }
    }
}

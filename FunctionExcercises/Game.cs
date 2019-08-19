using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExcercises
{
    class Game
    {
        int score = 100;
        public void Start()
        {
            Console.WriteLine("Your score is " + score);
            Console.ReadLine();
            score = AddToScore(50);
            Console.WriteLine("You have scored");
            Console.WriteLine("Your score is now " + score);
            Console.ReadLine();
            score = AddToScore(150);
            Console.WriteLine("You have scored again");
            Console.WriteLine("Your new score is " + score);
            Console.ReadLine();
            score = AddToScore(100);
            Console.WriteLine("You have scored again");
            Console.WriteLine("Your new score is " + score);
            Console.ReadLine();
        }

        int AddToScore(int add)
        {
            score += add;
            return score;
        }

        void PrintScore(int add)
        {

        }
    }
}

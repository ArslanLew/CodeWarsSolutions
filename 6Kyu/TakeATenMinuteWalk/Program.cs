using System;

namespace TakeATenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Challenge Description:
            You live in the city of Cartesia where all roads are laid  in a perfect grid.
            You arrived ten minutes too early to an appointment, so you decided to take 
            the opportunity to go for a short walk.The city provides its citizens with a 
            Walk Generating App on their phones-- everytime you press the button it sends 
            you an array of one - letter strings representing directions to walk(eg. ['n', 's', 'w', 'e']).
            You always walk only a single block for each letter (direction) and you know it takes you one 
            minute to traverse one city block, so create a function that will return true if the walk 
            the app gives you will take you exactly ten minutes(you don't want to be early or late!) 
            and will, of course, return you to your starting point. Return false otherwise.
            */

            //check if length != 10, value for horiz and vert = 0
         string[] walk = { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" };

            if (walk.Length != 10)
            {
                Console.WriteLine("false");
            }
            else
            {
                int horizontal = 0;
                int vertical = 0;
                foreach (string direction in walk)
                {
                    switch (direction)
                    {
                        case "n":
                            vertical++;
                            break;
                        case "s":
                            vertical--;
                            break;
                        case "e":
                            horizontal++;
                            break;
                        case "w":
                            horizontal--;
                            break;
                    }
                }
                if (horizontal == 0 && vertical == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

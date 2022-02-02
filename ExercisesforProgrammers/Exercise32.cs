using System;

namespace ExercisesforProgrammers
{
	class Exercise32
	{
        public void Solution32()
        {            
            Console.WriteLine("Let's play Guess the Number.");
            Choice();
        }

        public void Choice()
        {
            int nLevel;
            Console.Write("Pick a difficulty level (1, 2 or 3) : ");
            int.TryParse(Console.ReadLine(), out nLevel);

            switch(nLevel)
            {
                case 1:
                    int randomNumber1 = new Random().Next(1, 10);
					Console.WriteLine("Level 1 contains Number from 1 to 10 ");
                    Answer(randomNumber1);
                    break;

                case 2: 
                    int randomNumber2 = new Random().Next(1, 100);
                    Console.WriteLine("Level 2 contains Number from 1 to 100 ");
                    Answer(randomNumber2);                   
                    break;

                case 3:
                    int randomNumber3 = new Random().Next(1, 1000);
                    Console.WriteLine("Level 3 contains Number from 1 to 1000 ");
                    Answer(randomNumber3);                    
                    break;

				case 4:  return;

                default:
					Console.WriteLine("Incorrect Option.");
                    break;
            }
            Choice();
        }
        
        public void Answer(int randomNumber)
		{
            int nCount = 0;
            Console.WriteLine("I have my number. What's your Guess? ");

            while(true)
            {
                int guess = GetGuess();

                if(guess == randomNumber)
                {
                    nCount++;
                    Console.WriteLine("Your guess was correct. You guess the number in " +nCount + " Tries."); 
                    break;
                }

                if(guess > randomNumber)
                {
                    Console.Write("Your guess was too high. Guess again  ");
                    nCount++;
                }

                if(guess < randomNumber)
                {
                    Console.Write("Your guess was too low. Guess again  ");
                    nCount++;
                }
            }
        }

        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }
    }
}

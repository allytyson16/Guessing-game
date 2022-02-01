using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11); 
		
		    Console.Write("Guess the random number - ");
		    int guess = int.Parse(Console.ReadLine());
		
		    Console.WriteLine("The random number was {0}", randomNumber);
		
		    if(guess < randomNumber)
		    {
		    	Console.WriteLine("Your guess was too low.");
		    }
		    else if(guess > randomNumber)
		    {
		    	Console.WriteLine("Your guess was too high.");
		    }
		    else
		    {
		    	Console.WriteLine("Your guess was correct.");
		    }
			
	  }
   }
}

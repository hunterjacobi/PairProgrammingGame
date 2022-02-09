using storyVariables;

Player user = new Player(0, 0, 0, 0);

//Intro
Console.WriteLine("Hello! Welcome to Eleven Fifty Trail!");

//Getting players name
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Hello {userName}!");

//Rules
Console.WriteLine("In Eleven Fifty Trail you will be tasked with completing projects while maintaining your health, and working on passing the class.");
Console.WriteLine("You are in Eleven Fifty Academy's coding foundations course. Over the course of the next 5 weeks, you will learn the basics of coding.");
Console.WriteLine("Being on time to class won't be your own problem. You will have to grow your skills to pass challenges throughout the course.");
Console.WriteLine("You must pass with a “C” or higher, to move onto Immersion. Otherwise you will fail, and will need to repeat the course!");
Console.WriteLine("Failure to overcome the obstacles will result in a deduction in your grade level. The equivalent to failing class is losing 3 grade levels.");
Console.WriteLine("Don't worry tho!! Through extra credit opportunities, and listening to guest speakers you could raise your grade level!");






















namespace storyVariables
{
    class Player
    {

        public Player(int endurance, int focus, int intelligence, int speed)
        {

        }
    }


}
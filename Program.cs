namespace Variables_Williston_Angus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans initializes Jumping and Running to false
            bool isJumping = false, isRunning = false;
            // Declared random float variable
            double myDouble;
            // Assigns the favoriteNumber to 777
            favoriteNumber = 777;
            // Assigns myDouble to 999.9
            myDouble = 999.9;
            // Initializes constant finalGrade to 100.0
            const double finalGrade = 100.0;
            
            //Prints all variable to console
            Console.WriteLine("Favoriten #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myDouble);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string myName = "Stewart";
            int myAge = 20;
            char lastInitial = 'B';
            bool isLearning = true;
            double confidence = 99.9;
            decimal unHappy = 0.00m;
                
            
            Console.WriteLine("Would you like to know about me?");
            Console.WriteLine("\n(Y)es\n(N)o");
            string interested = Console.ReadLine();

            if (interested == "Y" || interested == "y")
            {
                Console.Clear();
                Console.WriteLine($"Hello, my name is {myName} {lastInitial}!\nI am {myAge} years old and it is very {isLearning} that I am learning to code right now!\nI have about {confidence}% confidence in myself for this course and I am {unHappy}% unhappy");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Okay, Have a good day.");
            }
            
        }
    }
}

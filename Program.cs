namespace Variables_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is what I followed along with the lecture

            int x; //declaration
            string playerName; //string declaration
            bool isSwimming;

            float grade = 99.99f; //initization
            bool isGrounded = true; //initizing isGrounded to true


            x = 6;
            Console.WriteLine(x); //writes 6 onto the console
            Console.WriteLine("What is your name, Player?");//asks the players name
            playerName = Console.ReadLine(); //player types their name
            Console.WriteLine(playerName); //player's name is written onto console

            string player1 = "P1", player2 = "P2", player3; //2 initilizations and one declaration on same line

            const int MAX_PLAYERS = 8; //sets max players to 8, can never change
            Console.WriteLine(MAX_PLAYERS); //prints max players to console


            //this is for the assignment

            int favoriteNumber; //an integer named "favoriteNumber"
            bool isJumping, isRunning = false; //isJumping and isRunning is set to false by a boolean
            float ball = 10.03f; //sets a floating point
            favoriteNumber = 19; //declares favorite number
            double finalGrade; //a double named final grade
            Console.WriteLine(favoriteNumber); //writes favoriteNumber onto the console
        }
    }
        
}
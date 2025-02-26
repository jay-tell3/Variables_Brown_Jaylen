using System.Runtime.InteropServices;

namespace Variables_Brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber; // makes a declaration int named favoriteNumber
            bool isJumping = false, isRunning = false; //makes two boolens set to false
            float asYouWish; // makes a declaration type float named asYouWish
            favoriteNumber = 26; // uses an assignment to change the favoriteNumber varable
            asYouWish = 123456; // uses an assignment to change the asYouWish varable
            const double finalGrade = 99.99; // uses initialiaztion and const to make a doyble varable named finalGrade stuck at 99.99
            Console.WriteLine(favoriteNumber); // Displays the data
            Console.WriteLine(isJumping); // Displays the data
            Console.WriteLine(isRunning);// Displays the data
            Console.WriteLine(asYouWish);// Displays the data
            Console.WriteLine(finalGrade);// Displays the data
        }
    }
}

using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7)
            {
                Console.WriteLine("Found seven!");
                break;
                //i++; 
                    //This skips 8 because theres no writeline
            }
        }
    }
}
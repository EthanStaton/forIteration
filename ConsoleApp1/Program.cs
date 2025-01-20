internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bob's Big Giveaway!");
        Console.Write("Choose 1, 2 or 3: ");


        string userValue = Console.ReadLine();

        string message = (userValue == "1") ? "boat" : "strand of lint";

        Console.WriteLine($"You have input {userValue}, therefore you win a {message}");
    }
}
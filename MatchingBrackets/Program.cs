namespace MatchingBrackets
{
    internal class Program : MatchingBracket
    {
        static void Main(string[] args)
        {
            var instanceOfMatchingBracket = new MatchingBracket();
            Console.WriteLine("Type text: ");
            var text = Console.ReadLine();
            Console.WriteLine(instanceOfMatchingBracket.HasMatchingBrackets(text));
        }
    }
}
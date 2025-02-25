namespace DesignPatterns.Utils
{
    public static class Helpers
    {
        public static void SetTitle(string title, ConsoleColor color = ConsoleColor.Green)
        {
            var stars = 50;
            var spaces = 5;

            Console.WriteLine();
            Console.ForegroundColor = color;
            Console.WriteLine(new string('*', stars));
            Console.WriteLine(string.Concat(new string(' ', spaces), title, new string(' ', spaces)));
            Console.WriteLine(new string('*', stars));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
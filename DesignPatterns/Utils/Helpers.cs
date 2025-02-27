namespace DesignPatterns.Utils
{
    public static class Helpers
    {
        public static void SetTitle(string title, Statut statut = Statut.Good, string description = "")
        {
            var stars = 50;
            var spaces = 5;

            Console.ForegroundColor = statut switch
            {
                Statut.Title => ConsoleColor.Blue,
                Statut.Good => ConsoleColor.Green,
                Statut.Bad => ConsoleColor.Red,
                _ => ConsoleColor.White,
            };
            Console.WriteLine();
            Console.WriteLine(new string('*', stars));
            Console.WriteLine(string.Concat(new string(' ', spaces), title, new string(' ', spaces)));
            if (!string.IsNullOrEmpty(description))
            {
                Console.WriteLine();
                Console.WriteLine(description);
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', stars));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
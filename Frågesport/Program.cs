
List<string> questions = ["How cold is absolute zero?", "What is the captial of Sweden?"];
List<string> a = ["-273", "Copenhagen"];
List<string> b = ["0", "Gotgenburg"];
List<string> c = ["-200", "London"];
List<string> d = ["50", "Stockholm"];
List<string> right = ["a", "d"];

int amtRight = 0;




Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                                                     Welcome!");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nYou will be asked a series of 10 Questions. Try and get as many as possible :)  Press Enter to Begin");
Console.ReadLine();

question();

void question()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    int qInt = Random.Shared.Next(a.Count);
    Console.WriteLine(questions[qInt] + "\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("a) " + a[qInt]);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("b) " + b[qInt]);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("c) " + c[qInt]);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("d) " + d[qInt] + "\n");
    Console.ForegroundColor = ConsoleColor.Magenta;
    string guess = Console.ReadLine();
    if (guess == right[qInt])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That is Right. Good job!");
        amtRight++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wrong!");
    }
    Console.ReadLine();
    questions.RemoveAt(qInt);
}

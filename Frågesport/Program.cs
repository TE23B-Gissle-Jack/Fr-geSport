
List<string> questions = ["How cold is absolute zero?", "What is the captial of Sweden?", "What is the most sold game in the world?", "What is the variable that is most often used to rperecent the speed of light?", "Who was the first American precident?", "Is this question rigged?", "In wich uppdate was Mincraft combat changed"];
List<string> a = ["-273", "Copenhagen", "Tetris", "E", "Abrehamn Lincon", "yes", "1.20"];
List<string> b = ["0", "Gotgenburg", "Fifa", "Mc^2", "Gorge Washington", "no", "2.0"];
List<string> c = ["-200", "London", "Minecraft", "C", "Rondald Reagan", "uhhhh", "1.18"];
List<string> d = ["50", "Stockholm", "Fortnite", "X", "Joe Biden", "both", "1.9"];
List<string> right = ["a", "d", "c", "c", "b", "c", "d"];

int amtRight = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("                                                     Welcome!");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nYou will be asked a series of 8 Questions. Try and get as many as possible :)  Press Enter to Begin");
Console.ReadLine();

TheQuiz();

void TheQuiz(){
 questions = ["How cold is absolute zero?", "What is the captial of Sweden?", "What is the most sold game in the world?", "What is the variable that is most often used to rperecent the speed of light?", "Who was the first American precident?", "Is this question rigged?", "In wich uppdate was Mincraft combat changed"];
 a = ["-273", "Copenhagen", "Tetris", "E", "Abrehamn Lincon", "yes", "1.20"];
 b = ["0", "Gotgenburg", "Fifa", "Mc^2", "Gorge Washington", "no", "2.0"];
 c = ["-200", "London", "Minecraft", "C", "Rondald Reagan", "uhhhh", "1.18"];
 d = ["50", "Stockholm", "Fortnite", "X", "Joe Biden", "both", "1.9"];
 right = ["a", "d", "c", "c", "b", "c", "d"];

Question();
FinalQuestion();
}

void Question()
{
    for (int i = 0; i < 7; i++)
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
            Right();
            amtRight++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Wrong();
        }
        //Console.ReadLine();
        questions.RemoveAt(qInt);
        a.RemoveAt(qInt);
        b.RemoveAt(qInt);
        c.RemoveAt(qInt);
        d.RemoveAt(qInt);
        right.RemoveAt(qInt);
    }
}

void FinalQuestion(){
    string finRightAwns;
    string promtR;
    string promtW;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Are you Smart?");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("a) yes");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("b) maybe");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("c) no");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("d) definetly not\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
    if(amtRight == 7)
    {
        finRightAwns = "a";
        promtR = "Yes you deffinetly are, Good Job";
        promtW = "No, i Actually thought you where smart, Wrong";
    }
    else if(5<= amtRight || amtRight <7)
    {
        finRightAwns = "b";
        promtR = "Yes you are, Good Job";
        promtW = "You apparently you arent smart";
    }
    else if(1<= amtRight || amtRight <4)
    {
        finRightAwns = "c";
        promtR = "That is Right Idiot";
        promtW = "The right Anwserer was NO, Idiot";
    }
    else{
        finRightAwns = "d";
        promtR = "First question you got right is it?, You´re still a fucking idiot";
        promtW = "Did you actually think you desered any other option then Defintely NO, fucking Idiot";
    }
    string guess = Console.ReadLine();
        if (guess == finRightAwns)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(promtR+ "\n");
            amtRight++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(promtW+ "\n");
        }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You got a Total of " +amtRight+ " Right out of the 8 Questions. You are welcome to try again\n");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Press Enter to Try Again");
    Console.ReadLine();
    TheQuiz();
}
void Wrong(){
    Console.WriteLine("""
                          .-'''-.                                       ___   
                         '   _    \                                  .'/   \  
                       /   /` '.   \    _..._                       / /     \ 
       _     _        .   |     \  '  .'     '.   .--./)            | |     | 
 /\    \\   //.-,.--. |   '      |  '.   .-.   . /.''\\             | |     | 
 `\\  //\\ // |  .-. |\    \     / / |  '   '  || |  | |            |/`.   .' 
   \`//  \'/  | |  | | `.   ` ..' /  |  |   |  | \`-' /              `.|   |  
    \|   |/   | |  | |    '-...-'`   |  |   |  | /("'`                ||___|  
     '        | |  '-                |  |   |  | \ '---.              |/___/  
              | |                    |  |   |  |  /'""'.\             .'.--.  
              | |                    |  |   |  | ||     ||           | |    | 
              |_|                    |  |   |  | \'. __//            \_\    / 
                                     '--'   '--'  `'---'              `''--'  

""");
}

void Right(){
    Console.WriteLine("""
  _______ _           _     _       _____  _       _     _     _ 
 |__   __| |         | |   (_)     |  __ \(_)     | |   | |   | |
    | |  | |__   __ _| |_   _ ___  | |__) |_  __ _| |__ | |_  | |
    | |  | '_ \ / _` | __| | / __| |  _  /| |/ _` | '_ \| __| | |
    | |  | | | | (_| | |_  | \__ \ | | \ \| | (_| | | | | |_  |_|
    |_|  |_| |_|\__,_|\__| |_|___/ |_|  \_\_|\__, |_| |_|\__| (_)
                                              __/ |              
                                             |___/               

""");
}

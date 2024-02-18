// Napisz program który przyjmie ciąg znaków i zwróci analizę ile razy występują poszczególne litery
Console.WriteLine("The program counts chars used in entered phrase");
Console.WriteLine();
var polishLetters = "0123456789aąbcćdeęfghijklłmnńoóprsśtquvwyzźż";
var polishChars = polishLetters.ToLower().ToCharArray();

while (true)
{
    Console.WriteLine("Enter your phrase or quit (q): ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    else if (input == " " || input == null)
    {
        Console.WriteLine("You did not enter any text. Try again!");
        continue;
    }
    else
    {
        var enteredTextToChar = input.ToLower().ToCharArray();
        int counter = 0;
        foreach (char ch in polishChars)
        {
            foreach (char ch1 in enteredTextToChar)
            {
                if (ch.Equals(ch1))
                    counter++;
            }
            if (counter != 0)
            {
                var messageToConsole = counter > 1 ?
                    $"{ch} = {counter} times" : $"{ch} = {counter} time";
                Console.WriteLine(messageToConsole);
                counter = 0;
            }
        }
    }
}
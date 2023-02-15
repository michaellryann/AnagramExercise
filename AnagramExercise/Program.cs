// See https://aka.ms/new-console-template for more information
var outputValue = false;

while(outputValue ==  false)
{
    Console.Clear();

    Console.WriteLine("Welcome to Anagram Checker!");
    Console.WriteLine("Enter first string: ");
    string firstString = Console.ReadLine();
    Console.WriteLine("Enter second string: ");
    string secondString = Console.ReadLine();

    if(firstString.Length == secondString.Length)
    {
        CheckAnagram(firstString, secondString);      
    }
    else
    {
        outputValue = false;
    }
}

Console.WriteLine("Thank you for useing Anagram Checker!");
Console.ReadLine();

void CheckAnagram(string stext1, string stext2)
{
    stext1 = String.Concat(stext1.ToLower().OrderBy(c => c));
    stext2 = String.Concat(stext2.ToLower().OrderBy(c => c));

    if (stext1 == stext2)
    {
        Console.WriteLine("Both Strings are Anagram");
        outputValue = true;
    }
    else
    {
        Console.WriteLine("Both String aren't Anagram");
        Console.WriteLine("Press Enter to try again");
        Console.ReadLine();
        outputValue = false;
    }
}
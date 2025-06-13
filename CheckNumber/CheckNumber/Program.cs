Console.WriteLine("Enter a number:");

string input = Console.ReadLine();

try
{   int inputNumb = int.Parse(input);
    Console.WriteLine("You entered a valid number: " + inputNumb);
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
finally
{
    Console.WriteLine("Block finally");
}
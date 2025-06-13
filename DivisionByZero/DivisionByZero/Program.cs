Console.WriteLine("Enter fist number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

try
{
    int result = firstNumber / secondNumber;
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}

finally
{
    Console.WriteLine("Execution completed.");
}

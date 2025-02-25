try
{
    Console.WriteLine("Multiplication Table Generator");
    Console.WriteLine("".PadLeft(30, '-'));
    Console.Write("Enter the starting number: ");
    var startNumber = Console.ReadLine();
    Console.Write("Enter the ending number: ");
    var endNumber = Console.ReadLine();
    if (!int.TryParse(startNumber, out var sNumber) ||
        !int.TryParse(endNumber, out var eNumber))
        throw new FormatException("Invalid inputs!");
    if (sNumber > eNumber || sNumber <= 0 || eNumber <= 0) 
        throw new FormatException("Invalid numbers!");
    for (var index = sNumber; index <= eNumber; index++)
    {
        Console.WriteLine($"\nMultiplication Table for {index}:");
    }
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
try
{
    Console.WriteLine("Multiplication Table Generator");
    Console.WriteLine("".PadLeft(30, '-'));
    Console.Write("Enter the starting number: ");
    var startNumber = Console.ReadLine();
    Console.Write("Enter the ending number: ");
    var endNumber = Console.ReadLine();
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
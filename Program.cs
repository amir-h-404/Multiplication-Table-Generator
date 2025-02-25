try
{
    Console.WriteLine("Multiplication Table Generator");
    Console.WriteLine("".PadLeft(30, '-'));
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
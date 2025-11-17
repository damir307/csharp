Console.Write("Enter number of eggs: ");
string input = Console.ReadLine();

try
{
    int eggs = int.Parse(input);
    Console.WriteLine($"Parsed with int.Parse: {eggs}");
}
catch
{
    Console.WriteLine("int.Parse failed!");
}

if (int.TryParse(input, out int result))
{
    Console.WriteLine($"Parsed with TryParse: {result}");
}
else
{
    Console.WriteLine("TryParse: incorrect number.");
}

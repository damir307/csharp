Console.Write("Enter something: ");
string s = Console.ReadLine();

if (int.TryParse(s, out int i))
{
    Console.WriteLine("This is int");
}
else if (double.TryParse(s, out double d))
{
    Console.WriteLine("This is double");
}
else if (bool.TryParse(s, out bool b))
{
    Console.WriteLine("This is bool");
}
else
{
    Console.WriteLine("Unknown type (string)");
}

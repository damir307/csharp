using System.Globalization;

var cultures = new[] {
    new CultureInfo("ru-RU"),
    new CultureInfo("en-US"),
    new CultureInfo("de-DE")
};

DateTime now = DateTime.Now;
double number = 1234567.89;

foreach (var c in cultures)
{
    Console.WriteLine($"Culture: {c.Name}");
    Console.WriteLine(now.ToString(c));
    Console.WriteLine(number.ToString("C", c));
    Console.WriteLine(number.ToString("N", c));
    Console.WriteLine();
}

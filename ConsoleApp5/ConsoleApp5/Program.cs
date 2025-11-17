string? nickname = null;

int GetNicknameLength(string? s) => s?.Length ?? 0;

Console.Write("Enter nickname (empty allowed): ");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
    nickname = null;
else
    nickname = input;

Console.WriteLine($"Length: {GetNicknameLength(nickname)}");

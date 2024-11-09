using _3_1;

Pair<int, char> pair = new Pair<int, char>(12, 'U');
Console.WriteLine($"First value: {pair.First}\nSecond value: {pair.Second}");
pair.First = 35;
pair.Second = 'T';
Console.WriteLine($"First changed value: {pair.First}\nSecond changed value: {pair.Second}");
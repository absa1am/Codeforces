HashSet<string> uniqueColor = new();
string[] inputs = Console.ReadLine().Split(' ');

for(int i = 0; i < 4; i++)
    uniqueColor.Add(inputs[i]);

Console.WriteLine(4 - uniqueColor.Count);
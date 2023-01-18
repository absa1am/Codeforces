int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string keyboard = Console.ReadLine();
    string word = Console.ReadLine();

    Dictionary<char, int> map = new();
    for(int j = 0; j < keyboard.Length; j++)
        map.Add(keyboard[j], j + 1);

    int cost = 0;
    for (int j = 1; j < word.Length; j++)
        cost += Math.Abs(map[word[j]] - map[word[j - 1]]);

    Console.WriteLine(cost);
}
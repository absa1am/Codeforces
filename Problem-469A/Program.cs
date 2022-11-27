int.TryParse(Console.ReadLine(), out int n);

string[] inputs;
HashSet<string> uniqueLevels = new();

inputs = Console.ReadLine().Split(' ');
for(int i = 1; i < inputs.Length; i++)
    uniqueLevels.Add(inputs[i]);

inputs = Console.ReadLine().Split(' ');
for(int i = 1; i < inputs.Length; i++)
    uniqueLevels.Add(inputs[i]);

if(uniqueLevels.Count == n) Console.WriteLine("I become the guy.");
else Console.WriteLine("Oh, my keyboard!");
int.TryParse(Console.ReadLine(), out int n);
string[] friends = Console.ReadLine().Split(' ');
byte[] answer = new byte[n + 1];

for(byte i = 1; i <= n; i++)
    answer[byte.Parse(friends[i - 1])] = i;

for(byte i = 1; i <= n; i++)
    Console.Write(answer[i] + " ");

Console.WriteLine();
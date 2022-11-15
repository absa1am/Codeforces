byte n = byte.Parse(Console.ReadLine());
string s = Console.ReadLine();

byte count = 0;
for(int i = 0; i <= n - 2; i++)
    if(s[i] == s[i + 1]) count++;

Console.WriteLine(count);
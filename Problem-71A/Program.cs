int.TryParse(Console.ReadLine(), out int n);

for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine();

    if(s.Length <= 10) Console.WriteLine(s);
    else Console.WriteLine($"{s[0]}{s.Length - 2}{s[^1]}");
}
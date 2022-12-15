int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine();

    if(s.ToLower() == "yes") Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
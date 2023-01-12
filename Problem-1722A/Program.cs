int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);
    char[] name = Console.ReadLine().ToCharArray();

    Array.Sort(name);
    
    if(new string(name) == "Timru") Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
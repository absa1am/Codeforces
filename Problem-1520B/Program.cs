int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string n = Console.ReadLine();

    int ans = 9 * (n.Length - 1) + (n[0] - '0' - 1);
    
    if(string.Compare(new string(n[0], n.Length), n) <= 0) Console.WriteLine(ans + 1);
    else Console.WriteLine(ans);
}
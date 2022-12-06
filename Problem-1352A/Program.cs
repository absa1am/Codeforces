int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string n = Console.ReadLine();
    List<string> ans = new List<string>();

    for(int j = 0; j < n.Length; j++)
    {
        if(n[j] > '0')
        {
            string s = n[j].ToString();

            for(int k = j + 1; k < n.Length; k++)
                s += '0';

            ans.Add(s);
        }
    }

    Console.WriteLine(ans.Count);
    
    foreach (var s in ans)
        Console.Write(s + " ");

    Console.WriteLine();
}
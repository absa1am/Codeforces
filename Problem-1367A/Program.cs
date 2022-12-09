int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string a, b = Console.ReadLine();

    a = string.Empty;
    for(int j = 0; j < b.Length; j += 2)
        a += b[j];
    
    a += b[b.Length - 1];
    Console.WriteLine(a);
}
string a = Console.ReadLine();
string b = Console.ReadLine();

for(int i = 0; i < a.Length; i++)
    Console.Write("{0}", a[i] == b[i]? "0":"1");

Console.WriteLine();
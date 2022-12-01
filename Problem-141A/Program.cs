string guest = Console.ReadLine();
string host = Console.ReadLine();
char[] letters = Console.ReadLine().ToCharArray();
char[] name = (guest + host).ToCharArray();

Array.Sort(name);
Array.Sort(letters);

if(new string(name) == new string(letters))
    Console.WriteLine("YES");
else Console.WriteLine("NO");
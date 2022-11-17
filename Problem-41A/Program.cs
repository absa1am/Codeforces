string s = Console.ReadLine();
char[] t = Console.ReadLine().ToArray();

Array.Reverse(t);

if(s == new string(t)) Console.WriteLine("YES");
else Console.WriteLine("NO");
int.TryParse(Console.ReadLine(), out int n);
string s = Console.ReadLine();

int anton = 0;
for(int i = 0; i < n; i++)
    if(s[i] == 'A') anton++;

if(anton > n - anton) Console.WriteLine("Anton");
else if(anton < n - anton) Console.WriteLine("Danik");
else Console.WriteLine("Friendship");
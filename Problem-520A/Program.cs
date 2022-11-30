int.TryParse(Console.ReadLine(), out int n);
string pangram = Console.ReadLine().ToLower();

bool[] letters = new bool[26];

int unique = 0;
for(int i = 0; i < n; i++)
{
    if(!letters[pangram[i] - 97]) unique++;
    letters[pangram[i] - 97] = true;
}

if(unique == 26) Console.WriteLine("YES");
else Console.WriteLine("NO");
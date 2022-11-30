string set = Console.ReadLine();

byte unique = 0;
bool[] letters = new bool[26];
for(int i = 0; i < set.Length; i++)
{
    if(set[i] >= 'a' && set[i] <= 'z')
    {
        if(!letters[set[i] - 97])
        {
            unique++;
            letters[set[i] - 97] = true;
        }
    }
}

Console.WriteLine(unique);
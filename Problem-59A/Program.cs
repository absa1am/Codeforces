string word = Console.ReadLine();

int count = 0;
for(int i = 0; i < word.Length; i++)
{
    if(char.IsLower(word[i])) count--;
    else count++;
}

if(count <= 0) Console.WriteLine(word.ToLower());
else Console.WriteLine(word.ToUpper());
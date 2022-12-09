string[] input;

input = Console.ReadLine().Split(' ');

int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

input = Console.ReadLine().Split(' ');

int validTeam = 0;
for(int i = 0; i < n; i++)
{
    if(k + int.Parse(input[i]) <= 5)
        validTeam++;
}

Console.WriteLine(validTeam / 3);
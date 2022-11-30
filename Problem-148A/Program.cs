int[] dragonStatus = new int[4];

for(int i = 0; i < 4; i++)
    int.TryParse(Console.ReadLine(), out dragonStatus[i]);

int.TryParse(Console.ReadLine(), out int d);

bool[] dragons = new bool[d + 1];
for(int i = 0; i < 4; i++)
{
    for(int j = 1; j <= d; j++)
        if(j % dragonStatus[i] == 0) dragons[j] = true;
}

int damaged = 0;
for(int i = 1; i <= d; i++)
    if(dragons[i]) damaged++;

Console.WriteLine(damaged);
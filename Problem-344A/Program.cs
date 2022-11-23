int.TryParse(Console.ReadLine(), out int n);

int previousMagnet = 0;
int numberOfMagnetGroup = 0;

for(int i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out int magnet);

    if(magnet != previousMagnet)
    {
        numberOfMagnetGroup++;
        previousMagnet = magnet;
    }
}

Console.WriteLine(numberOfMagnetGroup);
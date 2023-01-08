int[] dimension = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

bool isColoredPicture = false;
for(int i = 0; i < dimension[0]; i++)
{
    string line = Console.ReadLine();

    for(int j = 0; j < line.Length; j++)
    {
        if(line[j] == 'C' || line[j] == 'M' || line[j] == 'Y')
        {
            isColoredPicture = true;
            break;
        }
    }
}

if(isColoredPicture) Console.WriteLine("#Color");
else Console.WriteLine("#Black&White");
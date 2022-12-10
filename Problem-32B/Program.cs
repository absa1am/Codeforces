string brozeCode = Console.ReadLine();

for(int i = 0; i < brozeCode.Length; i++)
{
    if(brozeCode[i] == '.') Console.Write("0");
    else if(brozeCode[i + 1] == '.')
    {
        i++;
        Console.Write("1");
    }
    else {
        i++;
        Console.Write("2");
    }
}

Console.WriteLine();
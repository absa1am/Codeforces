int t = int.Parse(Console.ReadLine());

for(int j = 0; j < t; j++)
{
    int n = int.Parse(Console.ReadLine());
    string message = Console.ReadLine();

    int count = 0;
    for(int i = 0; i < n; i++)
    {
        if(message[i] == 'Q') count++;
        else if(count > 0) count--;
    }

    Console.WriteLine(count == 0? "Yes":"No");
}
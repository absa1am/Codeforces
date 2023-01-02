int.TryParse(Console.ReadLine(), out int n);

if(n % 2 == 0)
{
    int ans = n / 2;

    Console.WriteLine(ans);
    for(int i = 0; i < ans; i++)
        Console.Write(2 + " ");
}
else
{
    List<int> answer = new List<int>();

    while(n > 3)
    {
        n = n - 2;
        answer.Add(2);
    }

    answer.Add(3);

    Console.WriteLine(answer.Count);
    for(int i = 0; i < answer.Count; i++)
        Console.Write(answer[i] + " ");
}

Console.WriteLine();
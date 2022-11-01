int.TryParse(Console.ReadLine(), out int t);

for(int j = 0; j < t; j++)
{
    int.TryParse(Console.ReadLine(), out int n);
    string message = Console.ReadLine();

    Stack<char> s = new Stack<char>();
    for(int i = 0; i < n; i++)
    {
        if(message[i] == 'Q') s.Push(message[i]);
        else s.TryPop(out char c);
    }

    Console.WriteLine(s.Count == 0? "Yes":"No");
}
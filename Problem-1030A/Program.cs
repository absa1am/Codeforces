int.TryParse(Console.ReadLine(), out int n);
string[] parts = Console.ReadLine().Split(' ');

bool easy = true;
for(int i = 0; i < n; i++)
{
    if(parts[i] == "1")
    {
        easy = false;
        break;
    }
}

Console.WriteLine(easy? "EASY":"HARD");
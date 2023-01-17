string tableCard = Console.ReadLine();
string[] handCard = Console.ReadLine().Split(' ');

bool canPlay = false;
for(int i = 0; i < handCard.Length; i++)
{
    if (tableCard[0] == handCard[i][0] || tableCard[1] == handCard[i][1])
    {
        canPlay = true;
        break;
    }
}

if(canPlay) Console.WriteLine("YES");
else Console.WriteLine("NO");
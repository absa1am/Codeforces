int.TryParse(Console.ReadLine(), out int n);
int[] cardNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));

int sereja = 0, dima = 0;
int turn = 0, i = 0,  j = cardNumbers.Length - 1;

while(i <= j)
{
    turn++;

    int x = 0;
    if(cardNumbers[i] > cardNumbers[j]) x = cardNumbers[i++];
    else x = cardNumbers[j--];

    if(turn % 2 == 1) sereja += x;
    else dima += x;
}

Console.WriteLine("{0} {1}", sereja, dima);
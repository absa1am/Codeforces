int digits = 0;
bool isLucky = true;
string n = Console.ReadLine();

for(int i = 0; i < n.Length; i++)
    if(n[i] == '4' || n[i] == '7') digits++;

do
{
    if(digits % 10 != 4 && digits % 10 != 7)
    {
        isLucky = false;
        break;
    }

    digits /= 10;
}
while(digits > 0);

Console.WriteLine(isLucky? "YES":"NO");
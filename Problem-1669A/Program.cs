int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    string division = "Division ";
    int.TryParse(Console.ReadLine(), out int rating);

    if(rating <= 1399) division += "4";
    else if(rating >= 1400 && rating <= 1599) division += "3";
    else if(rating >= 1600 && rating <= 1899) division += "2";
    else division += "1";

    Console.WriteLine(division);
}
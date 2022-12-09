int.TryParse(Console.ReadLine(), out int n);
int[] skills = Array.ConvertAll(Console.ReadLine().Split(' '), skill => int.Parse(skill));
List<int> programmer = new();
List<int> mathematician = new();
List<int> physician = new(); 

for(int i = 0; i < n; i++)
{
    if(skills[i] == 1) programmer.Add(i + 1);
    else if(skills[i] == 2) mathematician.Add(i + 1);
    else physician.Add(i + 1);
}

int team = Math.Min(Math.Min(programmer.Count, mathematician.Count), physician.Count);

Console.WriteLine(team);

for(int i = 0; i < team; i++)
    Console.WriteLine("{0} {1} {2}", programmer[i], mathematician[i], physician[i]);
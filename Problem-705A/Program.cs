string[] feelings = {"I hate ", "I love "};

int.TryParse(Console.ReadLine(), out int n);

Console.Write(feelings[0]);
for(int i = 1; i < n; i++)
    Console.Write("{0} {1}", "that", feelings[i % 2]);

Console.WriteLine("it");
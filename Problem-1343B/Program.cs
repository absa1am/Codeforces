int.TryParse(Console.ReadLine(), out int t);

for(int i = 0; i < t; i++)
{
    int.TryParse(Console.ReadLine(), out int n);

    if(n % 2 == 1) Console.WriteLine("NO");
    else {
        if((n / 2) % 2 == 1) Console.WriteLine("NO");
        else {
            Console.WriteLine("YES");
            
            int sum = 0;
            for(int j = 2; j <= n; j += 2)
            {
                sum += j;
                Console.Write(j + " ");
            }
            
            for(int j = 1; j <= n - 2; j += 2)
            {
                sum -= j;
                Console.Write(j + " ");
            }

            Console.WriteLine(sum);
        }
    }
}
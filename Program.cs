using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var visited = new HashSet<string>();
        int bayanCount = 0;

        for (int i = 0; i < N; ++i)
        {
            string store = Console.ReadLine();
            if (visited.Contains(store))
            {
                bayanCount++;
            }
            else
            {
                visited.Add(store);
            }
        }

        Console.WriteLine(bayanCount);
    }
}

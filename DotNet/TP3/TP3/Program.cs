using System;
public class TP2
{
    public static void Main(string[] args)
    {
        int c, d, n,num, som;
        for (c = 1; c <= 5; c++)
        {for (d=0;d <= 9; d++)
                for (n = 0; n <= 9; n++)
                {
                    num = 100 * c + 10 * d + n;
                    som = c*c*c+d*d*d+n*n*n;
                    if (som == num)
                        Console.WriteLine(som);
                }
        }
    }
}
        
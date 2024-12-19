using System;
public class TP2
{
    public static void Main()
    {
        string chaine, second="";
        int Len = 0;
        chaine = Console.ReadLine();
        Len = chaine.Length;
        for (int i = Len-1; i>=0; i--)
        {
            second+=chaine[i];
        }
           
    Console.WriteLine(second);
    }
}

using System;
class TP4
{
    static void Main()
    {
        int[] tab = { 2, 3, 4, 5, 6, 5, 4 };
        Console.Write("le nombre pour ajouter ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("la position de nombre");
        int i = int.Parse(Console.ReadLine());
        int[] tab2 = new int[tab.Length+1];
        for(int j = 0; j < i; j++)
        {
            tab2[j] = tab[j];
        }
        tab2[i] = x;
        for(int j = i; j < tab.Length; j++)
        {
            tab2[j+1] = tab[j];
        }
        foreach (int j in tab2)
        {
            Console.Write(j + " ");
        }




    }
}
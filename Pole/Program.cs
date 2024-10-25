﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
	private static void Main(string[] args)
	{
		int[] array1 = [1, 2, 3, 4, 5];
        Console.WriteLine("Vypsani hodnot");
		foreach (int i in array1)
		{
			Console.WriteLine(i);
		}

		//TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
        int sum = 0;
        foreach (int i in array1)
        {
            sum += i;
        }
        Console.WriteLine(sum);
		//TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
		double average = (double)sum/array1.Length;
        Console.WriteLine("Prumer je: {0}", average);
		//TODO 5: Najdi maximum v poli a vypiš ho do konzole.
		int max = array1[0];
        foreach (int i in array1)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("Max: {0}", max);
		//TODO 6: Najdi minimum v poli a vypiš ho do konzole.
		int min = array1[0];
        foreach (int i in array1)
        {
            if (i < min)
            {
                min = i;
            }
        }
        Console.WriteLine("Min: {0}", min);
		//TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
		int input = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        foreach (int i in array1)
        {
            if (i == input)
            {
                Console.WriteLine("Index of {0} is {1}", input, index);
            }
            index++;
		}
		//TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
		Random rng = new Random();
        array1 = new int[100];
        for (int i = 0; i < 100; i++)
        {
            array1[i] = rng.Next(0,9);
        }


		//TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
		int[] counts = new int[10];
        foreach (int i in array1)
        {
            counts[i]++;
        }
        for (int i = 0; i<10; i++)
        {
            Console.Write(counts[i] + ", ");
        }
        
		//TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
        int[] array2 = array1;
        Array.Reverse(array2);
        

		//Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

		Console.ReadKey();
	}
}
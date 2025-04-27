﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter rows:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("enter cols:");
        int cols = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, cols];

        Console.WriteLine("enter elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"element [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\narray:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nreverse array:");
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = cols - 1; j >= 0; j--)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
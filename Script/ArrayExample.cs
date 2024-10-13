using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample
{
    
    public static void Main()
    {
        // Declaration and initialization
        int[] numbers = new int[5]; // Array of 5 integers

        // Assigning values to the array
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Accessing and printing array elements
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        // Another way to declare and initialize an array
        int[] moreNumbers = { 60, 70, 80, 90, 100 };

        // Accessing and printing array elements
        foreach (int number in moreNumbers)
        {
            Console.WriteLine("Element: " + number);
        }
    }
}

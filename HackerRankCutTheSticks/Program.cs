using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*
 * done on 05/05/2016
 * 
 * */

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int smallestElement = int.MaxValue;
        var keepGoing = true;
        while (keepGoing)
        {
            keepGoing = countNumberOfElementsAndOutputToStdIn(ref arr, n, ref smallestElement);
            makeCuts(ref arr, n, ref smallestElement);
            smallestElement = int.MaxValue;
        }
        
    }
    public static bool countNumberOfElementsAndOutputToStdIn(ref int[] arr, int n, ref int smallestElement)
    {
        int countLeft = 0;
        for(var i =0; i < arr.Length; i++)
        {
            if(arr[i] > 0 )
            {
                countLeft++;
                if (arr[i] < smallestElement)
                {
                    smallestElement = arr[i];
                }
            }
           
        }
        if(countLeft > 0)
        {
            System.Console.WriteLine(countLeft);
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void makeCuts(ref int[] arr, int n, ref int cutSize)
    {
        for (var i = 0; i < n; i++)
        {
            var elementLength = arr[i];
            if (elementLength > 0)
            {
                arr[i] = arr[i] - cutSize;
            }
        }
    }
}


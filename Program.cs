using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        //string a = "0", b = "0";
        
        int a = 0,b=0;
        int n= arr.ToArray().Length;
        Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    //Console.WriteLine(arr[i][j]);
                    a = a + arr[i][j];
                }
                
                if (i + j == n - 1)
                {
                    //Console.WriteLine(arr[i][j]);
                    b = b + arr[i][j];
                }
            }
        }
        
        int c = Math.Abs(a - b);
        return c;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        List<List<int>> arr = new List<List<int>>();
        arr.Add(new List<int> { 1, 2, 3 });
        arr.Add(new List<int> { 4, 5, 6 });
        arr.Add(new List<int> { 9, 8, -9 });
        int result = Result.diagonalDifference(arr);


        Console.WriteLine(result);
    }
}

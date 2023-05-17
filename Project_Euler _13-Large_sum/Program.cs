using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        BigInteger sum=0;
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sum += BigInteger.Parse(Console.ReadLine());
        }
        string result="1234567890";
        StringBuilder sb = new StringBuilder(sum.ToString());
        StringBuilder sb2 = new StringBuilder(result);
        for (int i = 0;i < 10; i++)
        {
            sb2[i] = sb[i];
        }

        Console.WriteLine(sb2.ToString());
    }
}
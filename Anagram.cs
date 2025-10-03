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

    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
         if (s.Length % 2 != 0)
        return -1;
        
    int n = s.Length;
    int mid = n / 2;
    
    int[] freq = new int[26];
    
    
    for (int i = 0; i < mid; i++)
    {
        freq[s[i] - 'a']++;
    }
    
 
    for (int i = mid; i < n; i++)
    {
        freq[s[i] - 'a']--;
    }
    
    
    int changes = 0;
    for (int i = 0; i < 26; i++)
    {
        if (freq[i] > 0)
        {
            changes += freq[i];
        }
    }
    
    return changes;
}

    }


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

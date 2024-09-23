using System;

public class SH
{
    public static void Main(string[] args)
    {
        string s = "SESMQADA";
        string rev = "";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            rev += s[i];  // Access characters using indexer
        }
        Console.WriteLine(rev);
    }
}

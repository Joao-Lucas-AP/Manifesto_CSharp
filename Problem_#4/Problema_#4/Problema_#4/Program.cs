using Problema__4;
using System;
using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        DateTime lastPalindromeDate = PalindromeDate.FindLastPalindromeDate();
        Console.WriteLine("The last palindrome date was: " + lastPalindromeDate.ToString("MM/dd/yyyy"));
    }
}
using System;

class BitwiseAnd
{
    public static void Main(string[] args)
    {
        int a = 6;
        int b = 3;
        
        //menggunakan operator bitwise and (&)
        int hasil = a & b;
        
        Console.WriteLine($"a & b = {hasil}");
    }
} 
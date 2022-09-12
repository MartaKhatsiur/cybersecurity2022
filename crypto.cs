using System;
using System.Security.Cryptography;
public class Ex2
{
    public static void Main(string[] args)
    {
        using (var r1 = new RNGCryptoServiceProvider())
        {
            var r2 = new byte[64];
            r1.GetBytes(r2);
            for (int i = 0; i < 5; i++)
                Console.Write(r2[i]);

        }
    }

}
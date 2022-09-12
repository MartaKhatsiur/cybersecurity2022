using System;
class Ex1{
    static void Main (string[] args)
        {
            var r = new Random(1000);
            for (int i = 0; i < 5; i++)
                Console.Write(r.Next(0,10) + " ");
        }
    }

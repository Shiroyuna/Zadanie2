using System;

class Zadanie2
{
    static void Main(string[] args)
    {
        long maxLength = 0;
        long maxStartingNumber = 0;

        for (long k = 1; k < 1000000; k++)
        {
            long n = k;
            long chainLength = 1;
            do
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                chainLength++;
            } 
            while (n != 1);

            if (chainLength > maxLength)
            {
                maxLength = chainLength;
                maxStartingNumber = k;
            }
        }

        Console.WriteLine("Liczba początkowa poniżej miliona, która tworzy najdłuższy łańcuch to: " + maxStartingNumber + "\n" +
            "Długość tego łańcucha: " + maxLength);
    }
}

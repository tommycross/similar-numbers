using System;

//
// I think this is mostly correct, but unsure about leading zeros after rearrangement.
// e.g. is 3000 similar to 3 30 or 300?  
//

class Solution
{
    public int solution(int N)
    {
        char[] charArray = N.ToString().ToCharArray();

        long divisor = 1;
        for (int digit = 0; digit <= 9; digit++)
        {
            int thisDigitCount = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].ToString() == digit.ToString())
                {
                    thisDigitCount++;
                }
            }
            if (thisDigitCount > 1)
            {
                divisor *= factorial(thisDigitCount);
            }
        }

        long result = factorial(charArray.Length) / divisor;

        return (int)result;
    }

    private static long factorial(int x)
    {
        long result = 1;
        for (int counter = 1; counter <= x; counter++) {
            result *= counter;
        }
        return result;
    }

    public static void Main()
    {
        Solution s = new Solution();

        Console.WriteLine("1 -> " + s.solution(1).ToString());
        Console.WriteLine("12 -> " + s.solution(12).ToString());
        Console.WriteLine("111 -> " + s.solution(111).ToString());
        Console.WriteLine("2247 -> " + s.solution(2247).ToString());
        Console.WriteLine("2227 -> " + s.solution(2227).ToString());
        Console.WriteLine("12345 -> " + s.solution(12345).ToString());
        Console.WriteLine("33158 -> " + s.solution(33158).ToString());
        Console.WriteLine("44449 -> " + s.solution(44449).ToString());
        Console.WriteLine("778800123 -> " + s.solution(778800123).ToString());
        Console.ReadKey();
    }
}


namespace ArturRios.AlgorithmPractice;

public static class MultiplesOfThreeOrFive
{
    /*
     * https://www.codewars.com/kata/514b92a657cdc65150000006/
     */
    public static int Solution(int value)
    {
        var sum = 0;
        
        for (var i = 1; i < value; i++)
        {
            if (IsMultipleOfThreeOrFive(i))
            {
                sum += i;
            }
        }
        
        return sum;
    }

    private static bool IsMultipleOfThreeOrFive(int value)
    {
        return value % 3 == 0 || value % 5 == 0;
    }
}
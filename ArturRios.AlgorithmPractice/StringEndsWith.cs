namespace ArturRios.AlgorithmPractice;

public static class StringEndsWith
{
    /*
     * https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d
     * Note: I know that .Net has the .EndsWith() method, just tried to figure out another solution without using it.
     */
    public static bool Solution(string str, string ending)
    {
        if (str.Length < ending.Length)
        {
            return false;
        }
        
        return str.Substring(str.Length - ending.Length) == ending;
    }
}
namespace ArturRios.AlgorithmPractice;

public static class ValidBraces
{
    /*
     * https://www.codewars.com/kata/5277c8a221e209d3f6000b56
     */
    public static bool Solution(string braces)
    {
        var open = new Stack<char>();

        foreach (var c in braces)
        {
            if (c is '(' or '[' or '{')
            {
                open.Push(c);

                continue;
            }

            var opener = c switch
            {
                ')' => '(',
                ']' => '[',
                '}' => '{',
                _ => default(char?)
            };

            if (opener is null)
            {
                continue;
            }

            if (open.Count == 0 || open.Pop() != opener)
            {
                return false;
            }
        }

        return open.Count == 0;
    }
}
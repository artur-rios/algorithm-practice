namespace ArturRios.AlgorithmPractice;

public static class ValidBraces
{
    /*
     * https://www.codewars.com/kata/5277c8a221e209d3f6000b56
     */
    public static bool Solution(string braces)
    {
        var valid = true;
        char lastChar = default;
      
        for(var i = 0;  i < braces.Length; i++) 
        {
            var c = braces[i];
            
            if (i == 0) 
            {
                if (c is ')' or '}' or ']') 
                {
                    valid = false;
                    
                    break;
                }
                
                lastChar = c;
            }

            if (i == braces.Length - 1)
            {
                if (c is '(' or '[' or '{')
                {
                    valid = false;
                    
                    break;
                }
            }

            if (lastChar is '(' && c is ']' or '}' 
                || lastChar is '{' && c is ')' or ']' 
                || lastChar is '[' && c is ')' or '}')
            {
                valid = false;
                
                break;
            }

            lastChar = c;
        }
      
        return valid;
    }
}
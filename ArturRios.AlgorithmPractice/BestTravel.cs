namespace ArturRios.AlgorithmPractice;

public static class BestTravel
{
    /*
     * https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa
     * Note: I don't want to use LINQ or recursivity
     */
    public static int? Solution(int t, int k, List<int> ls)
    {
        var sums = new List<int>();
        
        if (ls.Count < k)
        {
            return null;
        }
        
        var indexes = new int[k];

        for (var i = 0; i < k; i++)
        {
            indexes[i] = i;
        }

        while (true)
        {
            var sum = 0;
            
            for (var i = 0; i < k; i++)
            {
                sum += ls[indexes[i]];
            }
            
            sums.Add(sum);
            
            var position = k - 1;

            while (position >= 0 && indexes[position] == ls.Count - k + position)
            {
                position--;
            }

            if (position < 0)
            {
                break;
            }
            
            indexes[position]++;

            for (var i = position + 1; i < k; i++)
            {
                indexes[i] = indexes[i - 1] + 1;
            }
        }
        
        var bestSum = 0;

        foreach (var sum in sums)
        {
            if (sum > bestSum && sum <= t)
            {
                bestSum = sum;
            }
        }
        
        return bestSum > 0 ? bestSum : null;
    }
}
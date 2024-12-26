internal class Program
{
    private static void Main()
    {
        int[] nums = { 1, 2, 1, 3, 2, 5 };
        var result = SingleNumber(nums);
        foreach (var el in result) Console.WriteLine(el);
    }

    private static int[] SingleNumber(int[] array)
    {
        var res = new int[2];
        var countMap = new Dictionary<int, int>();

        foreach (var el in array)
            if (countMap.ContainsKey(el))
                countMap[el]++;
            else
                countMap[el] = 1;

        var index = 0;
        foreach (var p in countMap)
            if (p.Value == 1)
            {
                res[index] = p.Key;
                index++;

                if (index == 2) break;
            }

        return res;
    }
}
class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 1, 3, 2, 5};
        int[] result = SingleNumber(nums);
        foreach (int el in result) {
            Console.WriteLine(el);
        }
    }

    static int[] SingleNumber(int[] array)
    {
        
        int[] res = new int[2];
        var countMap = new Dictionary<int, int>();

        foreach (int el in array)
        {
            if (countMap.ContainsKey(el))
            {
                countMap[el]++;
            }
            else
            {
                countMap[el] = 1;
            }
        }
        int index = 0;
        foreach (var p in countMap)
        {
            if (p.Value == 1)
            {
                res[index] = p.Key;
                index++;

                if (index == 2)
                {
                    break;
                }
            }
        }
        
        return res;
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        Movezeroe(nums);
        foreach (int el in nums) {
            Console.WriteLine(el);
        }
    }

    static void Movezeroe(int[] array)
    {
        int p = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                array[p] = array[i];
                p++;
            }
        }

        // Заполняем оставшуюся часть массива нулями
        for (int i = p; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }
}
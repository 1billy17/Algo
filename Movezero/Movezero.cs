internal class Program
{
    private static void Main()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        Movezeroe(nums);
        foreach (var el in nums) Console.WriteLine(el);
    }

    private static void Movezeroe(int[] array)
    {
        var p = 0;

        for (var i = 0; i < array.Length; i++)
            if (array[i] != 0)
            {
                array[p] = array[i];
                p++;
            }

        // Заполняем оставшуюся часть массива нулями
        for (var i = p; i < array.Length; i++) array[i] = 0;
    }
}
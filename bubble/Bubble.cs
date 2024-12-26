internal class Prog
{
    private static void Main(string[] args)
    {
        static void BubbleSort(int[] array)
        {
            var i = array.Length - 1;
            while (i > 0)
            {
                var swap = 0;
                for (var j = 0; j < i; j++)
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = j;
                        foreach (var elem in array) Console.Write(elem + " ");
                        Console.WriteLine("");
                    }

                i = swap;
            }
        }

        var a = 0;
        var b = 0;
        a = Convert.ToInt32(Console.ReadLine());
        var array1 = new int[a];
        for (var k = 0; k < a; k++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            array1[k] = b;
        }

        BubbleSort(array1);
    }
}
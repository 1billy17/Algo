internal class Prog
{
    // функция которая рандомит элементы массива
    private static int[] RandomPer(int[] array)
    {
        var random = new Random();
        var n = array.Length;
        while (n > 1)
        {
            n--;
            var i = random.Next(n + 1);
            var temp = array[i];
            array[i] = array[n];
            array[n] = temp;

            foreach (var elem in array) Console.Write(elem + " ");
            Console.WriteLine();
        }

        return array;
    }

    // Функция проверяющая отсортирован ли массив
    private static bool IsSort(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
            if (array[i] > array[i + 1])
                return false;
        return true;
    }

    // функция которая рандомит массив, пока он не отсортируеться
    private static int[] Bogosort(int[] array)
    {
        while (IsSort(array) == false) array = RandomPer(array);
        return array;
    }


    private static void Main(string[] args)
    {
        var a = 0;
        var b = 0;
        a = Convert.ToInt32(Console.ReadLine());
        var array = new int[a];
        for (var k = 0; k < a; k++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            array[k] = b;
        }

        array = Bogosort(array);
    }
}
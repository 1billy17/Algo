class Prog{

    // функция которая рандомит элементы массива
    static int[] RandomPer(int[] array) {
        Random random = new Random();
        var n = array.Length;
        while (n > 1) {
            n--;
            var i = random.Next(n + 1);
            var temp = array[i];
            array[i] = array[n];
            array[n] = temp;
            
            foreach (int elem in array) {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
            
        return array;
    }
    // Функция проверяющая отсортирован ли массив
    static bool IsSort(int[] array) {
        for (int i = 0; i < array.Length - 1; i++) {
            if (array[i] > array[i + 1])
                return false;
        }
        return true;
    }

    // функция которая рандомит массив, пока он не отсортируеться
    static int[] Bogosort(int[] array) {
        while (IsSort(array) == false) {
            array = RandomPer(array);
        }
        return array;
    }
    

    static void Main(string[] args) {
        int a = 0;
        int b = 0;
        a = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[a];
        for (int k = 0; k < a; k++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            array[k] = b;
        }

        array = Bogosort(array);
    }
}
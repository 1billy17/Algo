using System.Timers;

class Prog {
    static void Main(string[] args) {
        static void BubbleSort(int[] array) 
        {
            int i = array.Length - 1;
            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = j;
                        foreach (int elem in array)
                        {
                            Console.Write(elem + " ");
                        }
                        Console.WriteLine("");
                    }
                }
                i = swap;
            }
        }

        int a = 0;
        int b = 0;
        a = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[a];
        for (int k = 0; k < a; k++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            array1[k] = b;
        }

        BubbleSort(array1);
    }
}
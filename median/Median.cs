public class MedianFinder
{
    private int[] _data;

    public MedianFinder() {

        _data = new int[]{};
    }

    public void AddNum(int num) {
        Array.Resize(ref _data, _data.Length + 1);
        _data[_data.Length - 1] = num;
    }

    public double FindMedian() {

        Array.Sort(_data);
        int mid = (_data.Length - 1) / 2;

        if (_data.Length % 2 == 0) {
            return (Convert.ToDouble(_data[mid]) + Convert.ToDouble(_data[mid + 1])) / 2; 
        } else {
            return _data[mid];
        }
    }
}

class Prog {
    static void Main() {
        MedianFinder medianFinder = new MedianFinder();
        medianFinder.AddNum(1);
        medianFinder.AddNum(2);
        Console.WriteLine(medianFinder.FindMedian());
    }
}
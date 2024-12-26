internal class Program
{
    private static void Main(string[] args)
    {
        // переменные
        string[] startTimeStrings = new[]
        {
            "10:00",
            "11:00",
            "15:00",
            "15:30",
            "16:50"
        };
        var startTimes = Array.ConvertAll(startTimeStrings,
            time => DateTime.ParseExact(time, "HH:mm", null).Add(DateTime.Today.TimeOfDay));
        var durations = new[] { 60, 30, 10, 10, 50 };
        var beginWorkingTime = DateTime.Today.AddHours(8);
        var endWorkingTime = DateTime.Today.AddHours(18);
        var consultationTime = 30;

        // вызов функции
        string[] result = DatesBumBum(beginWorkingTime, endWorkingTime, startTimes, durations, consultationTime);

        // вывод
        var count = 0;
        foreach (var date in result)
            if (!string.IsNullOrEmpty(date))
            {
                Console.WriteLine(date);
                count++;
            }

        Console.WriteLine(count);
    }

    private static string[] DatesBumBum(DateTime beginWorkingTime, DateTime endWorkingTime, DateTime[] startTimes,
        int[] durations, int consultationTime)
    {
        // переменные
        var maxIntervals = (int)((endWorkingTime - beginWorkingTime).TotalMinutes / consultationTime);
        string[] availablePeriods = new string[maxIntervals];
        var index = 0;
        var workTime = beginWorkingTime;
        var i = 0;

        // проход по рабочему времени
        while (workTime < endWorkingTime)
        {
            var nextBusyStart = i < startTimes.Length ? startTimes[i] : endWorkingTime;
            var availableTime = nextBusyStart - workTime;
            var availableMinutes = (int)availableTime.TotalMinutes;

            // проход по свободному времени
            while (availableMinutes >= consultationTime)
            {
                var nextAvailableEnd = workTime.AddMinutes(consultationTime);

                // Проверяем, чтобы не выходить за конец рабочего дня
                if (nextAvailableEnd > endWorkingTime) nextAvailableEnd = endWorkingTime;

                availablePeriods[index++] = $"{workTime:HH:mm}-{nextAvailableEnd:HH:mm}";

                workTime = nextAvailableEnd;
                availableMinutes -= consultationTime;
            }

            // Переход к следующему занятому периоду
            if (i < startTimes.Length)
            {
                workTime = startTimes[i].AddMinutes(durations[i]);
                i++;
            }
            else
            {
                break;
            }
        }

        return availablePeriods;
    }
}
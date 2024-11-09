public class Program
{
    public static void Main()
    {
        int[] intArr = [5, 3, 8, 1, 4];
        double[] doubleArr = [2.5, 3.1, 0.4, 8.7, 1.2];

        Console.WriteLine($"Минимальное значение при int: {FindMin(intArr)}");
        Console.WriteLine($"Минимальное значение при double: {FindMin(doubleArr)}");
    }

    public static T FindMin<T>(T[] arr) where T : IComparable<T>
    {
        T minValue = arr[0];

        foreach (T i in arr)
        {
            if (i.CompareTo(minValue) < 0)
            {
                minValue = i;
            }
        }
        return minValue;
    }
}
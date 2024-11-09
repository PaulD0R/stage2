namespace _3_1;

public class Pair<T1, T2>(T1 first, T2 second)
{
    private T1 _first = first;
    private T2 _second = second;

    public T1 First
    {
        get => _first;
        set => _first = (T1)value;
    }

    public T2 Second
    {
        get => _second;
        set => _second = (T2)value;
    }
}
namespace _3_3;

public class Repository<T> where T : class
{
    private List<T> _list = new List<T>();

    public void Add(T value)
    { 
        _list.Add(value);
    }
    
    public T Get(int index)
    {
        if (index < 0 || index >= _list.Count)
            throw new ArgumentOutOfRangeException();
        return _list[index];
    }
}
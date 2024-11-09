namespace _3_5;

public interface IStorage<T>
{
    void Add(T value);
    T Get(int index);
}
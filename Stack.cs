namespace Solution;

public class Stack<T> : IStack<T>
{
    public bool Empty => Count == 0;

    public bool Full => Count == Size;

    public int Count { get; }

    public int Size { get; }

    public T[] arr { get; }

    public Stack(int size = 4)
    {
        Size = size;
        Count = 0;
        arr = new T[4];
    }

    public T? Peek()
    {
        throw new NotImplementedException();
    }

    public T? Pop()
    {
        throw new NotImplementedException();
    }

    public void Push(T Item)
    {
        throw new NotImplementedException();
    }
}

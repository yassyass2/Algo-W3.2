namespace Solution;

public class Stack<T> : IStack<T>
{
    public bool Empty => Count == 0;

    public bool Full => Count == Size;

    public int Count { get; set; }

    public int Size { get; }

    public T[] arr { get; }
    public int Index { get; set; }

    public Stack(int size = 4)
    {
        Size = size;
        Count = 0;
        arr = new T[4];
        Index = -1;
    }

    public T? Peek()
    {
        return Index > -1 ? arr[Index] : null;
    }

    public T? Pop()
    {
        if (index < 0) return null;
        var temp = arr[Index];
        arr[Index] = default(T);
        Index--;
        Count--;
        return temp;
    }

    public void Push(T Item)
    {
        arr[++Index] = Item;
        Count++;
    }
}

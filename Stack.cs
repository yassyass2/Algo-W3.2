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
        arr = new T[size];
        Index = -1;
    }

    public T? Peek()
    {
        return Index > -1 ? arr[Index] : default(T);
    }

    public T? Pop()
    {
        if (Index < 0) return default(T);
        T temp = arr[Index];
        Index--;
        Count--;
        return temp;
    }

    public void Push(T Item)
    {
        Index = Index + 1 < Size ? Index + 1 : 0;
        arr[Index] = Item;
        Count++;
    }
}

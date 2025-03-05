namespace Solution;

public class Stack<T> : IStack<T>
{
    public bool Empty => Count == 0;

    public bool Full => Count == Size;

    public int Count { get; set; }

    public int Size { get; set; }

    public T[] arr { get; set; }
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
        return Index > -1 ? arr[Index] : default;
    }

    public T? Pop()
    {
        if (Index < 0) return default;
        T temp = arr[Index];
        Index--;
        Count--;
        return temp;
    }

    public void Push(T Item)
    {
        if (Full){
            int newSize = Size * 2;
            T[] newArr = new T[newSize];

            for (int i = 0; i < Size; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
            Size = newSize;
        }
        arr[++Index] = Item;
        Count++;
    }
}

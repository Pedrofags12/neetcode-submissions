public class DynamicArray
{
    private int[] arr;
    private int size;
    private int capacity;

    public DynamicArray(int capacity)
    {
        this.capacity = capacity;
        this.size = 0;
        this.arr = new int[capacity];
    }

    public int Get(int i)
    {
        return arr[i];
    }

    public void Set(int i, int n)
    {
        arr[i] = n;
    }

    public void PushBack(int n)
    {
        if (size == capacity)
        {
            Resize();
        }

        arr[size] = n;
        size++;
    }

    public int PopBack()
    {
        int value = arr[size - 1];
        size--;

        return value;
    }

    public void Resize()
    {
        int newCapacity = capacity * 2;
        int[] newArr = new int[newCapacity];

        for (int i = 0; i < size; i++)
        {
            newArr[i] = arr[i];
        }

        arr = newArr;
        capacity = newCapacity;
    }

    public int GetSize()
    {
        return size;
    }

    public int GetCapacity()
    {
        return capacity;
    }
}
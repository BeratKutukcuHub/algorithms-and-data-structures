
public class ArrayStack<T> : IStack<T>
{
    public int Count { get; private set; }
    private readonly List<T> ArrayStackList = new();
    public T Peek()
    {
        var item = ArrayStackList.Last();
        return item;
    }
    public T Pop()
    {
        var item = ArrayStackList.Last();
        ArrayStackList.RemoveAt(Count);
        Count--;
        return item;
    }
    public void Push(T value)
    {
        ArrayStackList.Add(value);
        Count++;
    }
}
public class LinkedListStack<T> : IStack<T>
{
    private readonly SinglyLinkedList.LinkedList<T> linkedListNode = new();
    public int Count { get; private set; }

    public T Peek()
    {
        return linkedListNode.Head.Value;
    }
    public T Pop()
    {
        var item = linkedListNode.Head.Value;
        linkedListNode.RemoveFirst();
        Count--;
        return item;
    }
    public void Push(T value)
    {
        linkedListNode.FirstAdd(value);
    }
}
public class Stack<T>
{
    private readonly IStack<T> stack;
    public int Count => stack.Count;
    public Stack(StackType type = StackType.Array)
    {
        if (type == StackType.Array)
        {
            stack = new ArrayStack<T>();
        }
        else
        {
            stack = new LinkedListStack<T>();
        }
    }
    public void Push(T value)
    {
        stack.Push(value: value);
    }
    public T Pop()
    {
        return stack.Pop();
    }
    public T Peek()
    {
        return stack.Peek();
    }
}


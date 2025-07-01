using DoublyLinkedList;

public class QueueArray<T> : IQueue<T>
{
    private readonly List<T> ArrayQueue = new();
    public int Count { get; private set; }

    public T deQueue()
    {
        var item = ArrayQueue[0];
        ArrayQueue.RemoveAt(0);
        return item;
    }
    public void enQueue(T val)
    {
        ArrayQueue.Add(val);
        Count++;
    }
    public T Peek()
    {
        return ArrayQueue[0];
    }
}
public class QueueLinkedList<T> : IQueue<T>
{
    private readonly DoublyLinkedList<T> doublyLinkedList = new();
    public int Count { get; private set; }
    public T deQueue()
    {
        var item = doublyLinkedList.Head.Value;
        doublyLinkedList.RemoveFirst();
        Count--;
        return item;
    }
    public void enQueue(T val)
    {
        doublyLinkedList.AddLast(val);
        Count++;
    }
    public T Peek()
    {
        return doublyLinkedList.Head.Value;
    }
}
public class Queue<T>
{
    private readonly IQueue<T> _queue;
    public int Count => _queue.Count;
    public Queue(QueueType queueType = QueueType.Array)
    {
        if (queueType == QueueType.Array)
        {
            _queue = new QueueArray<T>();
        }
        else _queue = new QueueLinkedList<T>();
    }
    public void enQueue(T val)
    {
        _queue.enQueue(val);
    }
    public T deQueue()
    {
        return _queue.deQueue();
    }
    public T Peek()
    {
        return _queue.Peek();
    }
}

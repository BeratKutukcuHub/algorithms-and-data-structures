public interface IQueue<T>
{
    public int Count { get; }
    void enQueue(T val);
    T deQueue();
    T Peek();
}
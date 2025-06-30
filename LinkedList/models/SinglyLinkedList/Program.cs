namespace SinglyLinkedList;
/// <summary>
/// Bağlı listenin tek bir düğümünü temsil eder.
/// </summary>
public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public LinkedListNode(T value)
    {
        Value = value;
        Next = null;
    }
}

/// <summary>
/// Tek yönlü bağlı liste veri yapısı.
/// </summary>
public class LinkedList<T>
{
    public LinkedListNode<T> Head { get; private set; }

    /// <summary>
    /// Listenin başına (en öne) eleman ekler. (LIFO mantığı)
    /// </summary>
    public void FirstAdd(T value)
    {
        var newNode = new LinkedListNode<T>(value);
        newNode.Next = Head;
        Head = newNode;
    }

    /// <summary>
    /// Listenin sonuna (en sona) eleman ekler.
    /// </summary>
    public void LastAdd(T value)
    {
        var newNode = new LinkedListNode<T>(value);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    public void AddAfter(T Value)
    {
        
    }
    /// <summary>
    /// Listedeki tüm elemanları sırayla yazdırır.
    /// </summary>
    public void PrintAll()
    {
        var current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
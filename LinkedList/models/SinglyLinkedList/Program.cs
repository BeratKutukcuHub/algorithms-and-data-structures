using System.Collections;

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
    public LinkedList() { }
    public LinkedList(IEnumerable<T> collections)
    {
        foreach (var item in collections)
        {
            this.FirstAdd(item);
        }
    }
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
    public void AddAfter(LinkedListNode<T> node, T Value)
    {
        if (node == null)
        {
            throw new Exception("Kanka Boş Yolluyorsun Olacak İş Değil?");
        }
        var instance = new LinkedListNode<T>(value: Value);
        var current = Head;
        while (current != null)
        {
            if (current.Equals(node))
            {
                instance.Next = current.Next;
                current.Next = instance;
            }
            current = current.Next;
        }
    }
    public void AddBefore(LinkedListNode<T> node, T Value)
    {
        var instance = new LinkedListNode<T>(value: Value);
        var current = Head;
        while (current != null)
        {
            if (current.Next == node)
            {
                instance.Next = node;
                current.Next = instance;
                return;
            }
            current = current.Next;
        }
    }
    public void RemoveFirst()
    {
        if (Head != null)
        {
            Head = Head.Next;
            return;
        }
    }
    public void Remove(LinkedListNode<T> node)
    {
        var current = Head;
        while (current.Next != null)
        {
            if (current.Next.Equals(node))
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }
    public void Remove(int index)
    {
        if (index <= -1)
        {
            return;
        }
        else if (index == 0)
        {
            bool check = Head.Next == null;
            if(check){ Head = null; return; }
            Head = Head.Next; return;          
        }
       int count = 0;
        var current = Head;

        while (current.Next != null)
        {
        if (count == index - 1)
        {
            current.Next = current.Next.Next;
            return;
        }
        current = current.Next;
        count++;
        }
    }
    public void RemoveLast()
    {
        if (Head.Next == null)
        {
            Head = null;
            return;
        }
        var current = Head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        current.Next = null;
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
    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }
}
public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        public T Current => _current.Value;
        object IEnumerator.Current => Current;
        private LinkedListNode<T> Head { get; set; }
        private LinkedListNode<T> _current { get; set; }
        public SinglyLinkedListEnumerator(LinkedListNode<T> head)
        {
            this.Head = head;
        }

        public void Dispose()
        {
            Head = null;
        }

    public bool MoveNext()
    {
        if (_current == null)
        {
            _current = Head;
            return true;
        }
        else
        {
            _current = _current.Next;
            return _current != null ? true : false;
        }
        }
        public void Reset()
        {
        _current = null;
        }
    }
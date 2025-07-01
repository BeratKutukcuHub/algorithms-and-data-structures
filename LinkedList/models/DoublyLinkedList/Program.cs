namespace DoublyLinkedList;

public class DoublyLinkedListNode<T>
{
    public DoublyLinkedListNode<T> Prev { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }
    public T Value { get; set; }
    public DoublyLinkedListNode(T value)
    {
        Value = value;
    }
}
public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> Head { get; set; }
    public DoublyLinkedListNode<T> Tail { get; set; }
    public void AddFirst(T value)
    {
        var instance = new DoublyLinkedListNode<T>(value);
        if (Head == null)
        {
            // Liste boşsa hem Head hem Tail bu yeni düğüm olur
            Head = Tail = instance;
        }

        instance.Next = Head;
        Head.Prev = instance;
        Head = instance;
    }
    public void AddLast(T value)
    {
        if (Tail == null)
        {
            AddFirst(value);
            return;
        }
        var instance = new DoublyLinkedListNode<T>(value);
        Tail.Next = instance;
        instance.Prev = Tail;
        Tail = instance;
        return;
    }
    public void AddAfter(DoublyLinkedListNode<T> referance, DoublyLinkedListNode<T> newNode)
    {
        if (referance == null) throw new Exception("Null");
        if (referance == Head && referance == Tail)
        {
            referance.Next = newNode;
            referance.Prev = null;

            newNode.Prev = referance;
            newNode.Next = null;

            Head = referance;
            Tail = newNode;
            return;
        }
        if (referance != Tail)
        {
            newNode.Next = referance.Next;
            newNode.Prev = referance;
            referance.Next = newNode;
            referance.Next.Prev = newNode;
        }
    }
    public void RemoveFirst()
    {
    if (Head == null) return; // boş liste

    if (Head.Next == null) // tek eleman varsa
    {
        Head = null;
        Tail = null;
        return;
    }

    Head = Head.Next;
    Head.Prev = null;
    }
    public void RemoveLast()
    {
    if (Tail == null) return; // boş liste

    if (Tail.Prev == null) // tek eleman varsa
    {
        Head = null;
        Tail = null;
        return;
    }

    Tail = Tail.Prev;
    Tail.Next = null;
    }
    public void Remove(int index)
    {
        int count = 0;
        var current = Head;
        while (current != null)
        {
            if (count == index)
            {
                if (current.Next != null)
                    current.Next.Prev = current.Prev;

                if (current.Prev != null)
                    current.Prev.Next = current.Next;

                // Eğer son elemanı kaldırıyorsak Tail güncelle
                if (current == Tail)
                    Tail = current.Prev;

                return;
            }
        current = current.Next;
        count++;
        }
    }
    public IEnumerable<T> ReturnNodes()
    {
        var current = Head;
        while (current != null)
        {
            if (current == Tail)
            {
                break;
            }
            else
            {
                yield return current.Value;
            }
            current = current.Next;
        }
    }
    public void AddBefore(DoublyLinkedListNode<T> referance, DoublyLinkedListNode<T> newNode)
    {
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }
        var previousNode = referance.Prev;

        newNode.Next = referance;
        newNode.Prev = previousNode;

        if (previousNode != null)
            previousNode.Next = newNode;
        else
            Head = newNode; // Başta ekleniyorsa, Head değişmeli

        referance.Prev = newNode;
    }
}

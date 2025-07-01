using DoublyLinkedList;
using SinglyLinkedList;

SinglyLinkedList.LinkedList<string> instance = new();
instance.FirstAdd("Ahmet");
instance.FirstAdd("Mehmet");
instance.FirstAdd("Lokal");

var doubly = new DoublyLinkedList<string>();
doubly.AddFirst("Ahnet");
doubly.AddFirst("Mehmet");
doubly.AddFirst("Ali");
doubly.AddFirst("Kefal");
doubly.AddFirst("Hamsi");
foreach (var item in doubly.ReturnNodes())
{
    Console.WriteLine(item);
}
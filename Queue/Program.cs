int[] charset = new[] {10 , 20, 30, 40, 50};
Queue<int> stackArrayChar = new Queue<int>();
Queue<int> stackLinkedListChar = new Queue<int>(QueueType.LinkedList);
foreach (var item in charset)
{
    stackArrayChar.enQueue(item);
    Console.WriteLine(stackArrayChar.deQueue());

    stackLinkedListChar.enQueue(item);
    Console.WriteLine(stackLinkedListChar.deQueue());
}

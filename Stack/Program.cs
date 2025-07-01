char[] charset = new[] { 'S', 'E', 'N', 'I', ' ', 'S', 'E', 'V', 'I', 'Y', 'O', 'R', 'U', 'M' };
Stack<char> stackArrayChar = new Stack<char>();
Stack<char> stackLinkedListChar = new Stack<char>(StackType.LinkedList);
foreach (var item in charset)
{
    stackArrayChar.Push(item);
    Console.WriteLine(stackArrayChar.Peek());

    stackLinkedListChar.Push(item);
    Console.WriteLine(stackLinkedListChar.Peek());
}

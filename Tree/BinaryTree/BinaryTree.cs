public class BinaryTree<T> where T : IComparable
{
    public void InOrder(TreeNode<T> root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.WriteLine(root);
            InOrder(root.Right);
        }
    }
    public void PreOrder(TreeNode<T> root)
    {
        if (root != null)
        {
            Console.WriteLine(root);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
    }
    public void PostOrder(TreeNode<T> root)
    {
        if (root != null)
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root);
        }
    }
    public void InOrderNonRecursive(TreeNode<T> node)
    {
        var list = new List<T>();
        var stack = new Stack<TreeNode<T>>();
        var loop = false;
        while (node != null || stack.Count > 0)
        {
        if (node != null)
        {
        stack.Push(node);
        node = node.Left;
        }
        else
        {
        node = stack.Pop();
        list.Add(node.Value);
        node = node.Right;
        }
    }
    }
}
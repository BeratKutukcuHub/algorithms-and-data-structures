using System.Collections;

public class BST<T> : IEnumerable<T> where T : IComparable
{
    public TreeNode<T> Root { get; set; }
    public BST() { }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Add(T value)
{
    var instance = new TreeNode<T>(value);

    if (Root == null)
    {
        Root = instance;
        return;
    }

    var current = Root;
    TreeNode<T> Parent;

    while (true)
    {
        Parent = current;
        if (value.CompareTo(current.Value) < 0)
        {
            current = current.Left;
            if (current == null)
            {
                Parent.Left = instance;
                return;
            }
        }
        else
        {
            current = current.Right;
            if (current == null)
            {
                Parent.Right = instance;
                return;
            }
        }
    }
}

}

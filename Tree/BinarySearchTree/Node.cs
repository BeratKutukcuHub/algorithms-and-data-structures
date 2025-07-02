using System.Collections;

public class TreeNode<T> 
{
    public TreeNode<T> Right { get; set; }
    public TreeNode<T> Left { get; set; }
    public T Value { get; set; }
    public override string ToString()
    {
        return $"{Value}";
    }
    public TreeNode(T value)
    {
        Value = value;
    }
    public TreeNode(){}
}
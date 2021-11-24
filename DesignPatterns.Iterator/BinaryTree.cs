namespace DesignPatterns.Iterator;

public class BinaryTree<T>
{
	private Node<T> _root;

	public BinaryTree(Node<T> root)
	{
		_root = root;
	}

	public IEnumerable<Node<T>> InOrder
	{
		get
		{
			foreach (var node in TraverseInOrder(_root))
			{
				yield return node;
			}
		}
	}

	private static IEnumerable<Node<T>> TraverseInOrder(Node<T> current)
	{
		if (current.Left is not null)
		{
			foreach (var left in TraverseInOrder(current.Left))
			{
				yield return left;
			}
		}

		yield return current;

		if (current.Right is not null)
		{
			foreach (var right in TraverseInOrder(current.Right))
			{
				yield return right;
			}
		}
	}
}
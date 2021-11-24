namespace DesignPatterns.Iterator;

public class BinaryTree<T>
{
	private Node<T> _root;

	public BinaryTree(Node<T> root)
	{
		_root = root;
	}

	public InOrderIterator<T> GetEnumerator()
	{
		return new InOrderIterator<T>(_root);
	}
}
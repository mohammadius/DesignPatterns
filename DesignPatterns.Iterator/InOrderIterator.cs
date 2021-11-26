namespace DesignPatterns.Iterator;

public class InOrderIterator<T>
{
	private readonly Node<T> _root;
	private bool _yieldedStart;
	public Node<T> CurrentNode { get; set; }
	public T Current => CurrentNode.Value;

	public InOrderIterator(Node<T> root)
	{
		_root = root;
		CurrentNode = root;

		while (CurrentNode.Left is not null)
		{
			CurrentNode = CurrentNode.Left;
		}
	}

	public bool MoveNext()
	{
		if (!_yieldedStart)
		{
			_yieldedStart = true;
			return true;
		}

		if (CurrentNode.Right is not null)
		{
			CurrentNode = CurrentNode.Right;
			while (CurrentNode.Left is not null)
			{
				CurrentNode = CurrentNode.Left;
			}

			return true;
		}

		var parent = CurrentNode.Parent;
		while (parent is not null && CurrentNode == parent.Right)
		{
			CurrentNode = parent;
			parent = parent.Parent;
		}

		CurrentNode = parent;
		return CurrentNode is not null;
	}

	public void Reset()
	{
		CurrentNode = _root;
		while (CurrentNode.Left is not null)
		{
			CurrentNode = CurrentNode.Left;
		}
		_yieldedStart = false;
	}
}
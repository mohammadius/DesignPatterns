// root-> 1
//     /     \
//    2       3
//   / \     / \
//  4   5   6   7

// in-order: 4 2 5 1 6 3 7

var root = new Node<int>(1,
	new Node<int>(2,
		new Node<int>(4), new Node<int>(5)),
	new Node<int>(3,
		new Node<int>(6), new Node<int>(7)));

foreach (var node in new BinaryTree<int>(root))
{
	Console.Write(node.Value);
	Console.Write(", ");
}

// foreach -> GetEnumerator() -> {Current, bool MoveNext()}

// https://docs.microsoft.com/en-us/dotnet/csharp/iterators#deeper-dive-into-foreach
// above code is turned (lowered) into this by compiler:
// InOrderIterator<int> enumerator = new BinaryTree<int>(root).GetEnumerator();
// while (enumerator.MoveNext())
// {
// 	var node = enumerator.Current;
// 	Console.WriteLine(node.Value.ToString());
// }
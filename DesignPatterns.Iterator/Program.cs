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
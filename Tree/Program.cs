﻿TreeNode<int> instance = new();
BST<int> ints = new();
ints.Add(3);
ints.Add(5);
ints.Add(10);
ints.Add(13);
ints.Add(8);
ints.Add(7);
ints.Add(4);
BinaryTree<int> binarySearch = new();
binarySearch.InOrder(ints.Root);
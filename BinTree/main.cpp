#include "BinTree.h"
#include <iostream>
#include <stdlib.h>
#include <exception>
#include <string>

using namespace std;

int main()
{
	int a, size = 0;
	BinTree tree;
	cout << "Enter size: ";
	cin >> size;
	for (int i = 0; i < size; i++)
	{
		cin >> a;
		tree.push(a);
	}
	tree.output();
	if (tree.find(4))
		cout << "True" << endl;
	else
		cout << "False" << endl;
	tree.pop(10);
	tree.output();
	return 0;
}
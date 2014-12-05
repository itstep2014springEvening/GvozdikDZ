#include "Vector.h"
#include <iostream>
#include <stdlib.h>
#include <exception>

using namespace std;

void zuzu(Vector a);

int main()
{
	try
	{
		double mas[3] = { 1, 2, 3 };
		Vector a(mas, 3), b(3);
		a.output();
		b.output();
		a = b;
		a.output();
		b.output();
		a = a;
		a.output();
		b.output();
		/*system("pause");
		for (int i = 0; i < 50; i++)
		{
		Vector b(1000000);
		cout << i << endl;
		zuzu(b);
		}*/
	}
	catch (exception &e)
	{
		cerr << e.what() << endl;
	}
	int n;
	cin >> n;
	return 0;
}

void zuzu(Vector a)
{

}
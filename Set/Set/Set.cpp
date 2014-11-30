#include "Set.h"
#include <iostream>
#include <utility>

using namespace std;

Set::Set()
{

}

Set::Set(int size) : array(nullptr), size(size)
{
	array = new int[this->size];
	for (int i = 0; i < this->size; i++)
		array[i] = i;
}

Set::Set(int *val, int size)
{
	this->size = size;
	array = new int[this->size];
	for (int i = 0; i < this->size; i++)
		array[i] = val[i];
}
Set::~Set()
{
	delete[] array;
}

Set::Set(Set &&other) :array(nullptr), size(0)
{
	swap(array, other.array);
	swap(size, other.size);
}

Set &Set::operator=(Set &&other)
{
	swap(array, other.array);
	swap(size, other.size);
	return *this;
}

Set::Set(const Set &other)
{
	size = other.size;
	array = new int[size];
	for (int i = 0; i < size; i++)
		array[i] = other.array[i];
}

Set &Set::operator=(const Set &other)
{
	if (this != &other)
	{
		delete[] array;
		size = other.size;
		array = new int[size];
		for (int i = 0; i < size; i++)
			array[i] = other.array[i];
		return *this;
	}
}

Set Set::unions(const Set &b)const
{
	int *temp;
	int count = 0, tempSize = b.size + this->size;
	temp = new int[tempSize];
	for (int i = 0; i < tempSize; i++)
	{
		if (i < this->size)
		{
			temp[i] = array[i];
			count++;
		}
	}
	for (int i = 0; i < this->size; i++)
	{
		for (int j = 0; j < this->size; i++)
			temp[count] = 1;
	}
	Set result(temp, count);
	delete[] temp;
	temp = nullptr;
	return result;

}

/*Set Set::complements(const Set &b)const
{

}*/

/*Set Set::intersections(const Set &b)const
{

}*/
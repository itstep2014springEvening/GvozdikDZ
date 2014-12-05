#include "Vector.h"
#include <iostream>
#include <utility>/*для 6 move и swap*/

using namespace std;

/*Vector::Vector(int size)
{
	this->size = size;
	array = new double[this->size];
	for (int i = 0; i < this->size; i++)
		array[i] = 0.0;
}*/

Vector::Vector(int size) : /*Список инициализации*/array(nullptr), size(size)
{
	array = new double[this->size];
	for (int i = 0; i < this->size; i++)
		array[i] = 0.0;
}

Vector::Vector(double *val, int size)
{
	this->size = size;
	array = new double[this->size];
	for (int i = 0; i < this->size; i++)
		array[i] = val[i];
}

Vector::~Vector()
{
	delete[] array;
}

Vector::Vector(Vector &&other) :array(nullptr), size(0) //Конструктор перемещения 
{
	swap(array, other.array);
	swap(size, other.size);
}

Vector &Vector::operator=(Vector &&other) //оператор переместительного присваивания
{
	swap(array, other.array);
	swap(size, other.size);
	return *this;
}

Vector::Vector(const Vector &other) //Конструктор копирования
{
	size = other.size;
	array = new double[size];
	for (int i = 0; i < size; i++)
		array[i] = other.array[i];
}

Vector &Vector::operator=(const Vector &vector/*ссылка*/) //Оператор присваивания
{
	if (this != &vector/*адрес*/)
	{
		delete[] array;
		size = vector.size;
		array = new double[size];
		for (int i = 0; i < size; i++)
			array[i] = vector.array[i];
		return *this/*для реализации цепочек операторов присваивания*/;
	}
}


/*Vector Vector::operator+(const Vector &b)const
{

}

Vector Vector::operator-(const Vector &b)const
{

}*/

double Vector::operator*(const Vector &b)const
{
	double result = 0.0;
	for (int i = 0; i < size; ++i)
		result += array[i] * b.array[i];
	return result;
}

void Vector::output()const
{
	for (int i = 0; i < size; i++)
		cout << array[i];
	cout << endl;
}
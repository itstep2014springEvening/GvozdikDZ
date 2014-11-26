#include "vector.h"
#include <iostream>

using namespace std;

Vector::Vector(double x, double y, double z)
{
    this->x = x;
    this->y = y;
    this->z = z;
}

Vector::~Vector()
{
    cout << "This is destructor" << endl;
    x = 0;
    y = 0;
    z = 0;
}

Vector Vector::sum(Vector &b)
{
    Vector result(0,0,0);
    result.x = x + b.x;
    result.y = y + b.y;
    result.z = z + b.z;
    return result;
}

Vector Vector::sub(Vector &b)
{
    Vector result(0, 0, 0);
    result.x = x - b.x;
    result.y = y - b.y;
    result.z = z - b.z;
    return result;
}

double Vector::vectorProd(Vector &b)
{
    Vector result(0, 0, 0);
    result.x = x * b.x;
    result.y = y * b.y;
    result.z = z * b.z;
    double resultProd = result.x + result.y + result.z;
    return resultProd;
}

Vector Vector::geomProd(Vector &b)
{
    Vector result(0, 0, 0);
    result.x = y * b.z - z * b.y;
    result.y = z * b.x - x * b.z;
    result.z = x * b.y - y * b.x;
    return result;
}

void Vector::output()
{
    cout << x << "," << y << "," << z << endl;
}

void Vector::input()
{
    cout << "Введите координаты вектора:" << endl;
    cin >> x;
    cin >> y;
    cin >> z;

}

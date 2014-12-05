#pragma once
class Vector
{
public:
	Vector(int size);
	Vector(double *val, int size);
	~Vector();
	Vector(Vector &&other);
	Vector(const Vector &other); //����������� �����������, ����� ���� �����.
	Vector &operator=(Vector &&other);
	Vector &operator=(const Vector &vector); //�������� ������������
	Vector operator+(const Vector &b)const;
	Vector operator-(const Vector &b)const;
	double operator*(const Vector &b)const;
	void output()const;
private:
	double *array;
	int size;
};
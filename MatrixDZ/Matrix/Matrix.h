#pragma once
class Matrix
{
public:
	Matrix();
	Matrix(int sizeRow, int sizeColumn);
	Matrix(int **val, int sizeRow, int sizeColumn);
	~Matrix();
	Matrix(Matrix &&other);
	Matrix(const Matrix &other);
	Matrix &operator=(Matrix &&other);
	Matrix &operator=(const Matrix &other);
	Matrix addition(const Matrix &b)const;
	Matrix subtraction(const Matrix &b)const;
	Matrix multiplication(const Matrix &b)const;
	void input();
	void output();
private:
	double **matrix;
	int sizeRow, sizeColumn;
};


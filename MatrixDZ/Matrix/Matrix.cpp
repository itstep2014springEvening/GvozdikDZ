#include "Matrix.h"
#include <iostream>
#include <utility>

using namespace std;

Matrix::Matrix()
{
	matrix = nullptr;
}

Matrix::Matrix(int sizeRow, int sizeColumn) : matrix(nullptr), sizeRow(sizeRow), sizeColumn(sizeColumn)
{
	matrix = new double*[this->sizeRow]();
	for (int i = 0; i < this->sizeRow; i++)
	{
		matrix[this->sizeRow] = new double[this->sizeColumn];
		for (int j = 0; j < this->sizeColumn; j++)
			matrix[i][j] = double(i + j);
	}
}

Matrix::Matrix(int **val, int sizeRow, int sizeColumn)
{
	matrix = new double*[this->sizeRow]();
	for (int i = 0; i < this->sizeRow; i++)
	{
		matrix[this->sizeRow] = new double[this->sizeColumn];
		for (int j = 0; j < this->sizeColumn; j++)
			matrix[i][j] = val[i][j];
	}
}
Matrix::~Matrix()
{
	for (int i = 0; i < sizeRow; i++)
	{
		delete[] matrix[i];
		matrix[i] = nullptr;
		delete[] matrix;
		matrix = nullptr;
	}
}

Matrix::Matrix(Matrix &&other) : matrix(nullptr), sizeRow(0), sizeColumn(0)
{
	swap(matrix, other.matrix);
	swap(sizeRow, other.sizeRow);
	swap(sizeColumn, other.sizeColumn);
}

Matrix &Matrix::operator=(Matrix &&other)
{
	swap(matrix, other.matrix);
	swap(sizeRow, other.sizeRow);
	swap(sizeColumn, other.sizeColumn);
	return *this;
}

Matrix::Matrix(const Matrix &other)
{
	sizeRow = other.sizeRow;
	sizeColumn = other.sizeColumn;
	matrix = new double*[sizeRow]();
	for (int i = 0; i < sizeRow; i++)
	{
		matrix[sizeRow] = new double[sizeColumn];
		for (int j = 0; j < sizeColumn; j++)
			matrix[i][j] = other.matrix[i][j];
	}
}

Matrix &Matrix::operator=(const Matrix &other)
{
	if (this != &other)
	{
		for (int i = 0; i < sizeRow; i++)
		{
			delete[] matrix[i];
			matrix[i] = nullptr;
			delete[] matrix;
			matrix = nullptr;
		}
		sizeRow = other.sizeRow;
		sizeColumn = other.sizeColumn;
		matrix = new double*[sizeRow]();
		for (int i = 0; i < sizeRow; i++)
		{
			matrix[sizeRow] = new double[sizeColumn];
			for (int j = 0; j < sizeColumn; j++)
				matrix[i][j] = other.matrix[i][j];
		}
	}
	return *this;
}

Matrix Matrix::addition(const Matrix &b)const
{
	Matrix result(sizeRow, sizeColumn);
	if (sizeRow == b.sizeRow && sizeColumn == b.sizeColumn)
	{
		result.matrix = new double*[sizeRow]();
		for (int i = 0; i < sizeRow; i++)
		{
			result.matrix[sizeRow] = new double[sizeColumn];
			for (int j = 0; j < sizeColumn; j++)
				result.matrix[i][j] = matrix[i][j] + b.matrix[i][j];
		}
		return result;
	}
	else
	{
		result.matrix = nullptr;
		return result;
	}
}

Matrix Matrix::subtraction(const Matrix &b)const
{
	Matrix result(sizeRow, sizeColumn);
	if (sizeRow == b.sizeRow && sizeColumn == b.sizeColumn)
	{
		result.matrix = new double*[sizeRow]();
		for (int i = 0; i < sizeRow; i++)
		{
			result.matrix[sizeRow] = new double[sizeColumn];
			for (int j = 0; j < sizeColumn; j++)
				result.matrix[i][j] = matrix[i][j] - b.matrix[i][j];
		}
		return result;
	}
	else
	{
		result.matrix = nullptr;
		return result;
	}
}

Matrix Matrix::multiplication(const Matrix &b)const
{
	Matrix result(sizeRow, b.sizeColumn);
	if (sizeRow == b.sizeColumn || sizeColumn == b.sizeRow)
	{
		result.matrix = new double*[sizeRow]();
		for (int i = 0; i < sizeRow; i++)
		{
			result.matrix[sizeRow] = new double[sizeColumn];
			for (int j = 0; j < sizeColumn; j++)
				for (int k = 0; k < sizeColumn; k++)
					result.matrix[i][j] += matrix[i][k] * b.matrix[k][j];
		}
		return result;
	}
	else
	{
		result.matrix = nullptr;
		return result;
	}
}

void Matrix::input()
{
	cout << "Enter matrix size: " << endl;
	cin >> sizeRow;
	cin >> sizeColumn;
}

void Matrix::output()
{
	for (int i = 0; i < sizeRow; i++)
	{
		for (int j = 0; j < sizeColumn; j++)
			cout << matrix[i][j] << ' ';
		cout << endl;
	}
}

#include "matrix.h"
#include <iostream>
#include <utility>
#include <iostream>

using namespace std;

Matrix::Matrix() : matrix(nullptr)
{
    sizeRow = 0;
    sizeColumn = 0;
}

Matrix::Matrix(int sizeRow, int sizeColumn) : matrix(nullptr)
{
    matrix = new double* [sizeRow]();
    for (int i = 0; i < sizeRow; ++i)
    {
        matrix[i] = new double[sizeColumn]();
        for (int j = 0; j < sizeColumn; ++j)
            matrix[i][j] = double(i + j);
    }
    this->sizeColumn = sizeColumn;
    this->sizeRow = sizeRow;
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
        }
        delete[] matrix;
        matrix = nullptr;
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

Matrix::~Matrix()
{
    if(matrix != nullptr)
    {
        for (int i = 0; i < sizeRow; i++)
        {
            delete[] matrix[i];
            matrix[i] = nullptr;
        }
        delete[] matrix;
        matrix = nullptr;
    }
}

Matrix Matrix::addition(const Matrix &b)const
{
    Matrix result(sizeRow, sizeColumn);
    if (sizeRow != b.sizeRow && sizeColumn != b.sizeColumn)
    {
        result.matrix = nullptr;
        cout << "Invalid input matrix!" << endl;
    }
    else
    {
        result.matrix = new double*[sizeRow]();
        for (int i = 0; i < sizeRow; i++)
        {
            result.matrix[i] = new double[sizeColumn];
            for (int j = 0; j < sizeColumn; j++)
                result.matrix[i][j] = matrix[i][j] + b.matrix[i][j];
        }
    }
    return result;
}

Matrix Matrix::subtraction(const Matrix &b)const
{
    Matrix result(sizeRow, sizeColumn);
    if (sizeRow != b.sizeRow && sizeColumn != b.sizeColumn)
    {
        result.matrix = nullptr;
        cout << "Invalid input matrix!" << endl;
    }
    else
    {
        result.matrix = new double*[sizeRow]();
        for (int i = 0; i < sizeRow; i++)
        {
            result.matrix[i] = new double[sizeColumn];
            for (int j = 0; j < sizeColumn; j++)
                result.matrix[i][j] = matrix[i][j] - b.matrix[i][j];
        }
    }
    return result;
}

Matrix Matrix::multiplication(const Matrix &b)const
{
    Matrix result(sizeRow, b.sizeColumn);
    if (sizeRow == b.sizeColumn || sizeColumn == b.sizeRow)
    {
        result.matrix = new double*[sizeRow]();
        for (int i = 0; i < sizeRow; i++)
        {
            result.matrix[i] = new double[b.sizeColumn];
            for (int j = 0; j < b.sizeColumn; j++)
                result.matrix[i][j] = matrix[i][j] * b.matrix[i][j];
        }
    }
    else
    {
        result.matrix = nullptr;
        cout << "Invalid input matrix!" << endl;
    }
    return result;
}

void Matrix::output()
{
    if(matrix != nullptr)
    {
        for (int i = 0; i < sizeRow; i++)
        {
            for (int j = 0; j < sizeColumn; j++)
                cout << matrix[i][j] << ' ';
            cout << endl;
        }
    }
}

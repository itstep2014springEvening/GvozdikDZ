#ifndef MATRIX_H
#define MATRIX_H

class Matrix
{
public:
    Matrix();
    Matrix(int sizeRow, int sizeColumn);
    Matrix(const Matrix &other);
    Matrix &operator=(const Matrix &other);
    Matrix(Matrix &&other);
    Matrix &operator=(Matrix &&other);
    ~Matrix();

    Matrix addition(const Matrix &b)const;
    Matrix subtraction(const Matrix &b)const;
    Matrix multiplication(const Matrix &b)const;

    void output();

private:
    double **matrix;
    int sizeRow;
    int sizeColumn;
};

#endif // MATRIX_H

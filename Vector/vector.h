#ifndef VECTOR_H
#define VECTOR_H

class Vector
{
public:
    Vector(double x, double y, double z);
    ~Vector();
    Vector sum(Vector &b);
    Vector sub(Vector &b);
    double vectorProd(Vector &b);
    Vector geomProd(Vector &b);
    void output();
    void input();
private:
    double x, y, z;
};

#endif // VECTOR_H

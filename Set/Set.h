#ifndef SET_H
#define SET_H

class Set
{
public:
    Set();
    Set(int size);
    Set(int *val, int size);
    ~Set();
    Set(Set &&other);
    Set(const Set &other);
    Set &operator=(Set &&other);
    Set &operator=(const Set &other);
    Set unions(const Set &b)const;
    //Set complements(const Set &b)const;
    //Set intersections(const Set &b)const;
private:
    int *array;
    int size;
};

#endif // SET_H
